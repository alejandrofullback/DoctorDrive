using System;
using Macaco.Infraestructure.Domain;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Repository.Model
{
    public class Person : EntityBase, IAggregateRoot
    {
        [DbParameter(ParameterName = "Name")]
        public string Name { get; set; }

        [DbParameter(ParameterName = "Code")]
        public string Code { get; set; }

        [DbParameter(ParameterName = "Email")]
        public string Email { get; set; }

        [DbParameter(ParameterName = "Phone")]
        public string Phone { get; set; }

        [DbParameter(ParameterName = "Address")]
        public string Address { get; set; }

        [DbParameter(ParameterName = "ZIP")]
        public string ZIP { get; set; }

        [DbParameter(ParameterName = "Birthday")]
        public DateTime Birthday { get; set; }

        [DbParameter(ParameterName = "IsFemale")]
        public bool IsFemale { get; set; }

        [DbParameter(ParameterName = "ContactName")]
        public string ContactName { get; set; }

        [DbParameter(ParameterName = "ContactPhone")]
        public string ContactPhone { get; set; }

        [DbParameter(ParameterName = "ContactEmail")]
        public string ContactEmail { get; set; }

        public override string Key
        {
            get { return "Id"; }
        }
    }
}
