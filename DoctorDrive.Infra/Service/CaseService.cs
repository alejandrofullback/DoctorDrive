using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Interface.IService;
using DoctorDrive.Infra.Model;

namespace DoctorDrive.Infra.Service
{
	public class CaseService : ICaseService
	{
		private ICaseRepository _caseRepository;
		private IPatientRepository _patientRepository;
		private IPersonRepository _personRepository;
		private IDoctorRepository _doctorRepository;

		public CaseService(ICaseRepository caseRepository, IPatientRepository patientRepository, IPersonRepository personRepository, IDoctorRepository doctorRepository)
		{
			_caseRepository = caseRepository;
			_patientRepository = patientRepository;
			_personRepository = personRepository;
			_doctorRepository = doctorRepository;
		}


		public Case CreateCase(Case newCase)
		{
			_personRepository.Add(newCase.Patient);
			_patientRepository.Add(newCase.Patient);
			if (newCase.Doctor != null)
			{
				_doctorRepository.Add(newCase.Doctor);
			}
			_caseRepository.Add(newCase);
			return newCase;
		}

		public List<Case> FindAll()
		{
			throw new NotImplementedException();
		}

		public List<Case> FindResume()
		{
			throw new NotImplementedException();
		}


		public Case UpdateCase(Case updateCase)
		{
			throw new NotImplementedException();
		}
	}
}
