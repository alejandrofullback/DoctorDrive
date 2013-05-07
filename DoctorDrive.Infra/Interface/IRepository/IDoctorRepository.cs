using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorDrive.Infra.Model;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Infra.Interface.IRepository
{
	public interface IDoctorRepository :   IBaseRepository<Doctor>
	{
	}
}
