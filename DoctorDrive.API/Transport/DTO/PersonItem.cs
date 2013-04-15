using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoctorDrive.API.Transport.DTO
{
    [Serializable, DataContract]
    public class PersonItem
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "code")]
        public string Code { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "phone")]
        public string Phone { get; set; }
        [DataMember(Name = "address")]
        public string Address { get; set; }
        [DataMember(Name = "zip")]
        public string ZIP { get; set; }
        [DataMember(Name = "birthday")]
        public DateTime Birthday { get; set; }
        [DataMember(Name = "isfemale")]
        public bool IsFemale { get; set; }
        [DataMember(Name = "contactname")]
        public string ContactName { get; set; }
        [DataMember(Name = "contactphone")]
        public string ContactPhone { get; set; }
        [DataMember(Name = "contactemail")]
        public string ContactEmail { get; set; }
    }
}