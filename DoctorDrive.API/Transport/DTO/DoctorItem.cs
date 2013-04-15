using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{
    [Serializable, DataContract]
    public class DoctorItem : PersonItem
    {
        [DataMember(Name = "chief")]
        public DoctorItem Chief { get; set; }

        [DataMember(Name = "position")]
        public string Position { get; set; }

        [DataMember(Name = "grade")]
        public string Grade { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}