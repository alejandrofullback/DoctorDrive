using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{
    public class DoctorItem : PersonItem
    {

        public DoctorItem Chief { get; set; }

    
        public string Position { get; set; }

      
        public string Grade { get; set; }

     
        public string Title { get; set; }
    }
}