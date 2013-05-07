using Macaco.Infraestructure.Domain;
using Macaco.Repository.Interface.IRepository;

namespace DoctorDrive.Infra.Model
{
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