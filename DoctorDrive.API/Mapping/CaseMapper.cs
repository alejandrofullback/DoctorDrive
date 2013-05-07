using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Infra.Model;

namespace DoctorDrive.API.Mapping
{
	public class CaseMapper
	{
		public class CaseItemsConverter : ITypeConverter<IEnumerable<PatientCase>, IEnumerable<PatientCaseItem>>
		{
			public IEnumerable<PatientCaseItem> Convert(ResolutionContext context)
			{
				var from = (IEnumerable<PatientCase>)context.SourceValue;

				return @from.Select(user => new PatientCaseItem
					{

					}).ToList();
			}
		}


		public class PatientCaseConverter : ITypeConverter<PatientCaseItem, PatientCase>
		{
			public PatientCase Convert(ResolutionContext context)
			{
				var source = (PatientCaseItem)context.SourceValue;

				return new PatientCase
				{
					ArrivalDate = source.ArrivalDate,
					Bed = source.Bed,
					
					Id = source.Id,
					IdDoctor = source.IdDoctor,
					IdPatient =  source.IdPatient,
					InitialDiagnostic = source.InitialDiagnostic,
					LastEvent =  source.LastEvent,
					MainDiagnostic = source.MainDiagnostic,
					Protocol = source.Protocol,
					RecentlyInterned = source.RecentlyInterned,
					Treatments = Macaco.Infraestructure.Infra.Serializer.Serialize(source.Treatments),
				};
			}
		}

		public class PatientCaseItemConverter : ITypeConverter<PatientCase, PatientCaseItem>
		{
			public PatientCaseItem Convert(ResolutionContext context)
			{
				var source = (PatientCase)context.SourceValue;

				return new PatientCaseItem
				{
					ArrivalDate = source.ArrivalDate,
					Bed = source.Bed,

					Id = source.Id,
					IdDoctor = source.IdDoctor,
					IdPatient = source.IdPatient,
					InitialDiagnostic = source.InitialDiagnostic,
					LastEvent = source.LastEvent,
					MainDiagnostic = source.MainDiagnostic,
					Protocol = source.Protocol,
					RecentlyInterned = source.RecentlyInterned,
					Treatments = Macaco.Infraestructure.Infra.Serializer.Deserialize<IList<TreatmentItem>>(source.Treatments),
				};
			}
		}
	}
}