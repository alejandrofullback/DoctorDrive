using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorDrive.Infra.Model;

namespace DoctorDrive.Infra.Interface.IService
{
    public interface ICaseService
    {
        Case CreateCase(Case newCase);
        List<Case> FindAll();
		List<Case> FindResume();
        Case UpdateCase(Case updateCase);
    }
}
