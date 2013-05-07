using System;
using System.Collections.Generic;
using System.Web.Http;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Infra.Interface.IService;
using DoctorDrive.Infra.Model;
using Macaco.Infraestructure.Mapping;

namespace DoctorDrive.API.Controllers
{
	public class CasesController : BaseController
	{
		private readonly IMapper _mapper;
        private readonly ICaseService _caseService;

		public CasesController(IMapper mapper,
            ICaseService caseService)
        {
            _mapper = mapper;
            _caseService = caseService;
        }

        //patients
        [HttpGet]
        public IEnumerable<PatientCaseItem> Get()
        {
            var cases = _caseService.FindAll();
            return _mapper.Map<IEnumerable<PatientCase>, IEnumerable<PatientCaseItem>>(cases);
        }

        [HttpGet]
        public PatientCaseItem GetById(int id)
        {
            var users = _caseService.FindById(id);
            return _mapper.Map<PatientCase, PatientCaseItem>(users);
        }

        [HttpPost]
        public PatientCaseItem Create(PatientCaseItem createdItem)
        {
            PatientCase item = _mapper.Map<PatientCaseItem, PatientCase>(createdItem);
	        item.Doctor = _mapper.Map<DoctorItem, Doctor>(createdItem.Doctor);
			item.Patient = _mapper.Map<PatientItem, Patient>(createdItem.Patient);

            _caseService.Add(item);
            
            return GetById(item.Id);
        }

        [HttpPut]
        public void Update(PatientCaseItem updateItem)
        {
            PatientCase item = _mapper.Map<PatientCaseItem, PatientCase>(updateItem);
            _caseService.Update(item);
        }

        [HttpDelete]
        public void Delete(PatientCaseItem deleteItem)
        {
            PatientCase item = _mapper.Map<PatientCaseItem, PatientCase>(deleteItem);
			_caseService.Update(item);
        }
	}
}