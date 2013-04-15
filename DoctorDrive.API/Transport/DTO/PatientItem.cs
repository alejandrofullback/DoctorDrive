using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{
    [Serializable, DataContract]
    public class PatientItem : PersonItem
    {
        [DataMember(Name = "weightkg")]
        public decimal? WeightKg { get; set; }

        [DataMember(Name = "isactive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "case")]
        public CaseItem Case { get; set; }

        [DataMember(Name = "doctor")]
        public DoctorItem Doctor { get; set; }
    }
}