using Microsoft.AspNetCore.Mvc;
using Bl;
using Webapi.models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bl.Api;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentManager _appointmentManager;

        public AppointmentController(IAppointmentManager appointmentManager)
        {
            _appointmentManager = appointmentManager;
        }

        // הזמנת תור
        [HttpPost("Book")]
        public async Task<IActionResult> Book([FromQuery] int availableAppointmentId, [FromQuery] string patientId)
        {
            try
            {
                await _appointmentManager.BookAppointment(availableAppointmentId, patientId);
                return Ok("Appointment booked successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Booking failed: {ex.Message}");
            }
        }

        // קבלת כל התורים הזמינים
        [HttpGet("Available")]
        public async Task<ActionResult<List<AvailableAppointment>>> GetAllAvailable()
        {
            var appointments = await _appointmentManager.GetAllAvailableAppointments();
            return Ok(appointments);
        }


        

        // קבלת תורים לפי תאריך
        [HttpGet("ByDate")]
        public async Task<ActionResult<List<AvailableAppointment>>> GetByDate([FromQuery] DateTime date)
        {
            var appointments = await _appointmentManager.GetAppointmentsByDate(date);
            return Ok(appointments);
        }

        

        // עדכון תור
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] AvailableAppointmentBl appointment)
        {
            var a = _appointmentManager.MakeAnAppointment(appointment);
            return Ok("Appointment updated.");
        }
    }
}
