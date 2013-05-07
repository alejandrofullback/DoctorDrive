using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Model;
using Macaco.Repository.Repository;

namespace DoctorDrive.Infra.Repository
{
	public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
	{
		public DoctorRepository()
			: base("Doctor")
        {
        }
	}
}
