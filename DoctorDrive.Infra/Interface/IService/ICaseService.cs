using System.Collections.Generic;
using DoctorDrive.Infra.Model;

namespace DoctorDrive.Infra.Interface.IService
{
    public interface ICaseService
    {
        List<PatientCase> FindAll();
		List<PatientCase> FindResume();
        PatientCase UpdateCase(PatientCase updateCase);
		PatientCase FindById(int id);
		PatientCase Add(PatientCase item);

		void Update(PatientCase item);
	}
}
