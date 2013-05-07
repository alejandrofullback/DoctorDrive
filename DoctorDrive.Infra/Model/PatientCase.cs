using System;
using Macaco.Infraestructure.Domain;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Infra.Model
{
    public class PatientCase : EntityBase, IAggregateRoot
    {
        public override string Key
        {
            get { return "Id"; }
        }
        public string Bed { get; set; }
        public int IdPatient { get; set; }
        public int Protocol { get; set; }
        public int IdDoctor { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string MainDiagnostic { get; set; }
        public string InitialDiagnostic { get; set; }
        public string RecentlyInterned { get; set; }
        public DateTime? LastEvent { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string Treatments { get; set; }
    }
}