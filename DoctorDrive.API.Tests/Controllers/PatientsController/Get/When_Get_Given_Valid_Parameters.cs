﻿using System.Linq;
using DoctorDrive.API.App_Start;
using DoctorDrive.Repository;
using DoctorDrive.Repository.IRepository;
using Macaco.Infraestructure.Mapping;
using Xunit;

namespace DoctorDrive.API.Tests.Controllers.PatientsController.Get
{
    public class When_Get_Given_Valid_Parameters
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

            var result = sut.Get();
            Assert.True(result.Count() > 0);

        }
    }
}
