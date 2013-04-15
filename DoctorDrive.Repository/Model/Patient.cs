using System;
using Macaco.Infraestructure.Domain;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Repository.Model
{
    public class Patient : EntityBase, IAggregateRoot
    {
        [DbParameter(ParameterName = "PersonId")]
        public int PersonId
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ZIP { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsFemale { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        [DbParameter(ParameterName = "WeightKg")]
        public decimal? WeightKg { get; set; }

        public string Pronctuary { get; set; }

        [DbParameter(ParameterName = "WeightKg")]
        public bool IsActive { get; set; }

        public Case Case { get; set; }
        public Doctor Doctor { get; set; }

        public override string Key
        {
            get { return "PersonId"; }
        }
    }

    public class Case : EntityBase, IAggregateRoot
    {
        public override string Key
        {
            get { return "Id"; }
        }
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

    public class Doctor : EntityBase, IAggregateRoot
    {
        public Doctor Chief { get; set; }
        public string Position { get; set; }
        public string Grade { get; set; }
        public string Title { get; set; }

        public override string Key
        {
            get { return "PersonId"; }
        }

    }
}
