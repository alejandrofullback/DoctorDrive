using System;
using System.Runtime.Serialization;

namespace DoctorDrive.API.Transport.DTO
{
	[Serializable, DataContract]
	public class DoctorItem : PersonItem
	{
		[DataMember(Name = "chief")]
		public DoctorItem Chief { get; set; }

		[DataMember(Name = "position")]
		public string Position { get; set; }

		[DataMember(Name = "grade")]
		public string Grade { get; set; }

		[DataMember(Name = "title")]
		public string Title { get; set; }
	}

	[Serializable, DataContract]
	public class TreatmentItem
	{
		[DataMember(Name = "name")]
		public int Id { get; set; }
		[DataMember(Name = "initialdate")]
        public DateTime InitialDate { get; set; }
		[DataMember(Name = "enddate")]
        public DateTime? EndDate { get; set; }
		[DataMember(Name = "description")]
        public string Description { get; set; }
		[DataMember(Name = "creatorid")]
        public int CreatorId{ get; set; }
		[DataMember(Name = "patientid")]
        public int PatientId{ get; set; }
        [DataMember(Name = "executorid")]
        public int? ExecutorId{ get; set; }

	}
}