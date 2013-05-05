using System;
using System.Collections.Generic;
using System.Web.Http;
using DoctorDrive.API.Transport.DTO;


namespace DoctorDrive.API.Controllers
{
    //[EnableCors("http://example.com,http://webapisample.azurewebsites.net", "","POST,PUT,DELETE,GET", 255000000, true)]
    public class PatientsController : ApiController
    {

        //patients
        [HttpGet]
        public IEnumerable<PatientItem> Get()
        {
          return new List<PatientItem>();
        }

        [HttpGet]
        public PatientItem GetById(int id)
        {
           return new PatientItem();
        }


        //patients/12345678  GetBy Id
        public PatientItem Get(int id)
        {
            return new PatientItem();
        }


        [HttpPost]
        public PatientItem Create(PatientItem createdItem)
        {
            return new PatientItem();
        }

        [HttpPut]
        public void Update(PatientItem updateItem)
        {
            return;
        }

        [HttpDelete]
        public void Delete(PatientItem deleteItem)
        {
            return;
        }
    }
}