using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DoctorDrive.Repository.IRepository;
using DoctorDrive.Repository.Model;
using Macaco.Repository.Repository;

namespace DoctorDrive.Repository
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository()
            : base("Patient")
        {
        }

        public override IEnumerable<Patient> FindAll()
        {
            IEnumerable<Patient> items;
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                items = cn.Query<Patient>("SELECT * FROM Patient INNER JOIN Person ON Person.Id = Patient.PersonId WHERE IsActive=1");
            }
            return items;
        }

        public override Patient FindById(int id)
        {

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                return cn.Query<Patient>("SELECT * FROM Patient INNER JOIN Person ON Person.Id = Patient.PersonId WHERE PersonId=@Id AND IsActive=1", new { Id = id }).SingleOrDefault();
            }
        }

    }
}
