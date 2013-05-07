using System;
using Macaco.Infraestructure.Domain;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Infra.Model
{
    public class Patient : Person, IAggregateRoot
    {
        //Entity
        public override string Key
        {
            get { return "PersonId"; }
        }

        [DbParameter(ParameterName = "PersonId")]
        public int PersonId
        {
            get { return Id; }
            set { Id = value; }
        }
        [DbParameter(ParameterName = "WeightKg")]
        public decimal? WeightKg { get; set; }
        [DbParameter(ParameterName = "IsActive")]
        public bool IsActive { get; set; }

    }
}
