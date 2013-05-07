using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Macaco.Infraestructure.Domain;

namespace DoctorDrive.Infra.Model
{
    public class Treatment
    {
        [DbParameter(ParameterName = "InitialDate")]
        public DateTime InitialDate { get; set; }
        [DbParameter(ParameterName = "EndDate")]
        public DateTime? EndDate { get; set; }
        [DbParameter(ParameterName = "PersonId")]
        public string Description { get; set; }
        [DbParameter(ParameterName = "int")]
        public int CreatorId
        {
            get { return Creator.Id; }
        }
        [DbParameter(ParameterName = "PatientId")]
        public int PatientId
        {
            get { return Patient.Id; }
        }
        [DbParameter(ParameterName = "ExecutorId")]
        public int? ExecutorId
        {
            get
            {
                return Executor == null ? (int?)null : Executor.Id;
            }
        }

        //tables
        public Patient Patient { get; set; }
        public Doctor Creator { get; set; }
        public Doctor Executor { get; set; }
    }
}
