using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{

    public class CaseItem
    {
        
        public int Id { get; set; }

        public int IdPatient { get; set; }

        public int Protocol { get; set; }

        public int IdDoctor { get; set; }

        public DateTime ArrivalDate { get; set; }

        public string MainDiagnostic { get; set; }

        public string InitialDiagnostic { get; set; }

        public string RecentlyInterned { get; set; }

        public DateTime? LastEvent { get; set; }

        public string Bed { get; set; }
    }
}