using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourtEndahAPI_v1.DomainClasses;
using CourtEndahAPI_v1.Data;
using CourtEndahAPI_v1.Request;

namespace CourtEndahAPI_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtController : ControllerBase
    {
        private readonly BookingContext _context;

        public CourtController(BookingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourts()
        {
            return Ok(await _context.COURT_Ts.ToListAsync());
        }

        

    }
}
