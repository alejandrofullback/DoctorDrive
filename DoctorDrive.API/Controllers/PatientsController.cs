using System;
using System.Collections.Generic;
using System.Web.Http;
using DoctorDrive.API.Filters;
using DoctorDrive.API.Transport.DTO;
using DoctorDrive.Repository.IRepository;
using DoctorDrive.Repository.Model;
using Macaco.Infraestructure.Mapping;

namespace DoctorDrive.API.Controllers
{
    public class PatientsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IPatientRepository _patientRepository;
        private readonly IPersonRepository _personRepository;

        public PatientsController(IMapper mapper,
            IPatientRepository patientRepository, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _patientRepository = patientRepository;
            _personRepository = personRepository;
        }


        //patients
        [HttpGet]
        public IEnumerable<PatientItem> Get()
        {
            var users = _patientRepository.FindAll();
            return _mapper.Map<IEnumerable<Patient>, IEnumerable<PatientItem>>(users);
        }

        [HttpGet]
        public PatientItem GetById(int id)
        {
            var users = _patientRepository.FindById(id);
            return _mapper.Map<Patient, PatientItem>(users);
        }


        //patients/12345678  GetBy Id
        public PatientItem Get(int id)
        {
            var patient = _patientRepository.FindById(id);
            if (patient == null) throw new ArgumentNullException("id");

            var user = _patientRepository.FindById(id);
            if (user == null) throw new NotFoundException();
            return _mapper.Map<Patient, PatientItem>(user);
        }


        [HttpPost]
        public void Create(PatientItem createdItem)
        {
            Patient item = _mapper.Map<PatientItem, Patient>(createdItem);
            Person person = _mapper.Map<PatientItem, Person>(createdItem);
            _personRepository.Add(person);
            item.Id = person.Id;
            _patientRepository.Add(item);
        }

        [HttpPut]
        public void Update(PatientItem updateItem)
        {
            Patient item = _mapper.Map<PatientItem, Patient>(updateItem);
            _patientRepository.Update(item);
        }

        [HttpDelete]
        public void Delete(PatientItem deleteItem)
        {
            Patient item = _mapper.Map<PatientItem, Patient>(deleteItem);
            _patientRepository.Update(item);
        }
    }
}