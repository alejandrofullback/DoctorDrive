using DoctorDrive.Repository.IRepository;
using DoctorDrive.Repository.Model;
using Macaco.Repository.Repository;

namespace DoctorDrive.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository()
            : base("Person")
        {
        }
    }
}
