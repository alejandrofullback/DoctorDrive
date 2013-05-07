using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Model;
using Macaco.Repository.Repository;

namespace DoctorDrive.Infra.Repository
{
	public class CaseRepository : BaseRepository<Case>, ICaseRepository
	{
		public CaseRepository()
            : base("Case")
        {
        }
	}
}
