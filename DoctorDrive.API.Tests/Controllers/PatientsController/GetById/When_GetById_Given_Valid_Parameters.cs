using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorDrive.API.App_Start;
using DoctorDrive.Repository;
using DoctorDrive.Repository.IRepository;
using Macaco.Infraestructure.Mapping;
using Xunit;

namespace DoctorDrive.API.Tests.Controllers.PatientsController.GetById
{
    public class When_GetById_Given_Valid_Parameters
    {
        [Fact]
        public void Returns_Valid_Patient()
        {
            // Arrange 
            AutoMapperBootStrapper.Configure();
            IMapper mapper = new AutoMapperService();
            IPatientRepository patientRepository = new PatientRepository();
            IPersonRepository personRepository = new PersonRepository();
            var sut = new API.Controllers.PatientsController(mapper, patientRepository, personRepository);

            Assert.NotNull(sut.GetById(1));

        }
    }
}
