﻿using System;
using DoctorDrive.API.App_Start;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Repository;
using DoctorDrive.Repository.IRepository;
using FizzWare.NBuilder;
using Macaco.Infraestructure.Mapping;
using Xunit;

namespace DoctorDrive.API.Tests.Controllers.PatientsController.Add
{
    public class When_Add_Patient_Given_Valid_Parameters
    {
        [Fact]
        public void Successfully_Add_New_Patient()
        {
            // Arrange 
            AutoMapperBootStrapper.Configure();
            IMapper mapper = new AutoMapperService();
            IPatientRepository patientRepository = new PatientRepository();
            IPersonRepository personRepository = new PersonRepository();
            var sut = new API.Controllers.PatientsController(mapper, patientRepository, personRepository);


            var fakePatient = Builder<PatientItem>.CreateNew()
                                   .With(x => x.IsActive = true)
                                   .With(x=> x.Code = Guid.NewGuid().ToString("N")
                                   )
                               .Build();


            var fakeCase = Builder<CaseItem>.CreateNew()
                               .Build();



            var fakeDoctor = Builder<DoctorItem>.CreateNew()
                               .Build();

            fakePatient.Case = fakeCase;
            fakePatient.Doctor = fakeDoctor;


            //act
            sut.Create(fakePatient);

        }

    }
}