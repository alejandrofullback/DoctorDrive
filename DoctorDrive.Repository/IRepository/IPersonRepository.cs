using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorDrive.Repository.Model;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Repository.IRepository
{
    public interface IPersonRepository : IBaseRepository<Person>
    {

    }
}
