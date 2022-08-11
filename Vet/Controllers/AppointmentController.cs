using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Vet.Models;
namespace Vet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly VeteriContext _context;
        public AppointmentController(VeteriContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Appointment>> Get()
        {
            var datas = _context.Appointments.ToListAsync();
            return await datas;
        }

        [HttpGet("Count")]
        public async Task<ActionResult<int>> GetCount()
        {
            int result = await _context.Appointments.CountAsync();
            return Ok(result);
        }

    }
}
