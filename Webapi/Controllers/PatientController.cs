using Bl.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi.models;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public IPatientManager PatientBl;
        public PatientController(IBlManager blManager)
        {
            PatientBl = blManager.PatientManager;
        }
        [HttpPost]
        public void addPatient([FromBody] PatientBl patient)
        {
            PatientBl.AddPatient(patient);
        }
        //complete the code
        [HttpGet("{id}")]
        public PatientBl GetPatient(string id)
        {
            return PatientBl.GetPatient(id);
        }
        [HttpGet("date/{date}")]
        public List<PatientBl> GetPatientsAppointmentByDate(DateTime date)
        {
            return PatientBl.GetPatientsAppointmentByDate(date);
        }
        [HttpGet("doctor/{doctorId}/date/{date}")]

        public List<PatientBl> GetPatientsByDoctorId(DateTime date, string doctorId)
        {
            return PatientBl.GetPatientsByDoctorId(date, doctorId);
        }
        [HttpDelete("{id}/{phoneNumber}")]
        public void deletePatient(string id)
        {
            PatientBl.RemovePatient(id, null); // Assuming phoneNumber is not needed for deletion
        }
        [HttpPut]
        public void UpdatePatient([FromBody] PatientBl patient)
        {
            PatientBl.UpdatePatient(patient);
        }


        [HttpGet("all")]
        public List<PatientBl> GetAllPatients()
        {
            return PatientBl.GetPatients();


        }

    }

}
