using DoctorDrive.API.App_Start;
using DoctorDrive.Infra.Interface.IRepository;
using DoctorDrive.Infra.Interface.IService;
using DoctorDrive.Infra.Repository;
using DoctorDrive.Infra.Service;
using Macaco.Infraestructure.Mapping;
using Xunit;

namespace DoctorDrive.API.Tests.Controllers.CasesController.GetById
{
    public class When_GetById_Given_Valid_Parameters
    {
        [Fact]
        public void Returns_Valid_Patient()
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

			//Assert.NotNull(sut.GetById(1));

        }
    }
}
