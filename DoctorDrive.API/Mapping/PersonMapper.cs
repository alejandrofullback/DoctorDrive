using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Infra.Model;

namespace DoctorDrive.API.Mapping
{
    public class PersonMapper
    {
        public class PersonItemsConverter : ITypeConverter<IEnumerable<Person>, IEnumerable<PersonItem>>
        {
            public IEnumerable<PersonItem> Convert(ResolutionContext context)
            {
                var from = (IEnumerable<Person>)context.SourceValue;

                return @from.Select(Mapper.Map<Person, PersonItem>).ToList();
            }
        }
    }
}