using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{
    [Serializable, DataContract]
    public class CaseItem
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "idpatient")]
        public int IdPatient { get; set; }

        [DataMember(Name = "protocol")]
        public int Protocol { get; set; }


        [DataMember(Name = "iddoctor")]
        public int IdDoctor { get; set; }

        [DataMember(Name = "arrivaldate")]
        public DateTime ArrivalDate { get; set; }

        [DataMember(Name = "maindiagnostic")]
        public string MainDiagnostic { get; set; }

        [DataMember(Name = "initialdiagnostic")]
        public string InitialDiagnostic { get; set; }

        [DataMember(Name = "recentlyinterned")]
        public string RecentlyInterned { get; set; }

        [DataMember(Name = "lastevent")]
        public DateTime? LastEvent { get; set; }

        [DataMember(Name = "bed")]
        public string Bed { get; set; }
    }
}