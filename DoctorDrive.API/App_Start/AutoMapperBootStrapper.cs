using System.Collections.Generic;
using AutoMapper;
using DoctorDrive.API.Mapping;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Repository.Model;

namespace DoctorDrive.API.App_Start
{
    public class AutoMapperBootStrapper
    {
        public static void Configure()
        {
            Mapper.CreateMap<IEnumerable<Patient>, IEnumerable<PatientItem>>().ConvertUsing(new PatientMapper.PatientItemsConverter());
            Mapper.CreateMap<PatientItem, Patient>().ConvertUsing(new PatientMapper.PatientConverter());
            Mapper.CreateMap<PatientItem, Person>().ConvertUsing(new PatientMapper.PatientPersonConverter());
            Mapper.CreateMap<Patient, PatientItem>().ConvertUsing(new PatientMapper.PatientItemConverter());
            

        }
    }
}
