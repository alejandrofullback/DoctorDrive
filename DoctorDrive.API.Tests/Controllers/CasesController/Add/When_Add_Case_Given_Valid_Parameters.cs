using System;
using DoctorDrive.API.App_Start;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Interface.IService;
using DoctorDrive.Infra.Model;
using DoctorDrive.Infra.Repository;
using DoctorDrive.Infra.Service;
using FizzWare.NBuilder;
using Macaco.Infraestructure.Mapping;
using Xunit;

namespace DoctorDrive.API.Tests.Controllers.CasesController.Add
{
	public class When_Add_Case_Given_Valid_Parameters
	{
		[Fact]
		public void Successfully_Add_New_Patient()
		{
			// Arrange 
			AutoMapperConfig.Configure();
			IMapper mapper = new AutoMapperService();
			IPatientRepository patientRepository = new PatientRepository();
			IDoctorRepository doctorRepository = new DoctorRepository();
			IPersonRepository personRepository = new PersonRepository();
			ICaseRepository caseRepository = new CaseRepository();
			ICaseService caseService = new CaseService(caseRepository, patientRepository, personRepository, doctorRepository);
			var sut = new API.Controllers.CasesController(mapper, caseService);


			var fakePatient = Builder<PatientItem>.CreateNew()
								   .With(x => x.IsActive = true)
								   .With(x => x.Code = Guid.NewGuid().ToString("N")
								   )
							   .Build();

			var fakeDoctor = Builder<DoctorItem>.CreateNew()
					   .With(x => x.Position = "CTI Manager")
					   .With(x => x.Code = Guid.NewGuid().ToString("N")
					   )
				   .Build();

			var fakeTreatments = Builder<TreatmentItem>.CreateListOfSize(2)
				   .Build();

			var fakeCase = Builder<PatientCaseItem>.CreateNew()
					   .With(x => x.Patient = fakePatient)
					   .With(x => x.Treatments = fakeTreatments)
					   .With(x=> x.Doctor = fakeDoctor)
				   .Build();


			//Act
			sut.Create(fakeCase);

			//Asssert
			Assert.True(fakeCase.Id > 0);


		}

	}
}
