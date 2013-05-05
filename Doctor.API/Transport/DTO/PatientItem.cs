using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{

    public class PatientItem : PersonItem
    {

        public decimal? WeightKg { get; set; }

 
        public bool IsActive { get; set; }


        public CaseItem Case { get; set; }

        public DoctorItem Doctor { get; set; }
    }
}