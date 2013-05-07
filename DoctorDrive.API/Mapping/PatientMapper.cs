using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Infra.Model;

namespace DoctorDrive.API.Mapping
{
    public class PatientMapper
    {
        public class PatientItemsConverter : ITypeConverter<IEnumerable<Patient>, IEnumerable<PatientItem>>
        {
            public IEnumerable<PatientItem> Convert(ResolutionContext context)
            {
                var from = (IEnumerable<Patient>)context.SourceValue;

                return @from.Select(user => new PatientItem
                    {
                        WeightKg = user.WeightKg,
                        Address = user.Address,
                        Birthday = user.Birthday,
                        Code = user.Code,
                        ContactEmail = user.ContactEmail,
                        ContactName = user.ContactEmail,
                        ContactPhone = user.ContactPhone,
                        Email = user.Email,
                        Id = user.Id,
                        IsFemale = user.IsFemale,
                        Name = user.Name,
                        Phone = user.Phone,
                        ZIP = user.ZIP,
                        IsActive = user.IsActive,
                        Case = new CaseItem(),
                        Doctor = new DoctorItem(),
                    }).ToList();
            }
        }


        public class PatientConverter : ITypeConverter<PatientItem, Patient>
        {
            public Patient Convert(ResolutionContext context)
            {
                var user = (PatientItem)context.SourceValue;

                return new Patient
                {
                    WeightKg = user.WeightKg,
                    Address = user.Address,
                    Birthday = user.Birthday,
                    Code = user.Code,
                    ContactEmail = user.ContactEmail,
                    ContactName = user.ContactEmail,
                    ContactPhone = user.ContactPhone,
                    Email = user.Email,
                    Id = user.Id,
                    IsFemale = user.IsFemale,
                    Name = user.Name,
                    Phone = user.Phone,
                    ZIP = user.ZIP,
                    IsActive = user.IsActive,
                };
            }
        }

        public class PatientItemConverter : ITypeConverter<Patient, PatientItem>
        {
            public PatientItem Convert(ResolutionContext context)
            {
                var user = (Patient)context.SourceValue;

                return new PatientItem
                {
                    WeightKg = user.WeightKg,
                    Address = user.Address,
                    Birthday = user.Birthday,
                    Code = user.Code,
                    ContactEmail = user.ContactEmail,
                    ContactName = user.ContactEmail,
                    ContactPhone = user.ContactPhone,
                    Email = user.Email,
                    Id = user.Id,
                    IsFemale = user.IsFemale,
                    Name = user.Name,
                    Phone = user.Phone,
                    ZIP = user.ZIP,
                    IsActive = user.IsActive,
                    Case = new CaseItem(),
                    Doctor = new DoctorItem(),
                };
            }
        }


        public class PatientPersonConverter : ITypeConverter<PatientItem, Person>
        {
            public Person Convert(ResolutionContext context)
            {
                var user = (PatientItem)context.SourceValue;

                return new Person
                {
                    Address = user.Address,
                    Birthday = user.Birthday,
                    Code = user.Code,
                    ContactEmail = user.ContactEmail,
                    ContactName = user.ContactEmail,
                    ContactPhone = user.ContactPhone,
                    Email = user.Email,
                    Id = user.Id,
                    IsFemale = user.IsFemale,
                    Name = user.Name,
                    Phone = user.Phone,
                    ZIP = user.ZIP,
                };
            }
        }
    }
}