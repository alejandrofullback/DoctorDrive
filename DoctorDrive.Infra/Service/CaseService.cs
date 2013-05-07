using System;
using System.Collections.Generic;
using System.Linq;
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



		public List<PatientCase> FindAll()
		{
			var cases = new List<PatientCase>(_caseRepository.FindAll());
			var patients = new List<Patient>(_patientRepository.FindAll());
			var doctors = new List<Doctor>(_doctorRepository.FindAll());

			foreach (var myCase in cases)
			{
				myCase.Patient = patients.FirstOrDefault(x => x.PersonId == myCase.IdPatient);
				myCase.Doctor = doctors.FirstOrDefault(x => x.Id == myCase.IdDoctor);
			}
			return cases;
		}

		public List<PatientCase> FindResume()
		{
			throw new NotImplementedException();
		}


		public PatientCase UpdateCase(PatientCase updateCase)
		{
			throw new NotImplementedException();
		}


		public PatientCase FindById(int id)
		{
			throw new NotImplementedException();
		}

		public PatientCase Add(PatientCase newCase)
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


		public void Update(PatientCase item)
		{
			throw new NotImplementedException();
		}
	}
}
