using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Model;
using Macaco.Repository.Repository;

namespace DoctorDrive.Infra.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository()
            : base("Person")
        {
        }
    }
}
