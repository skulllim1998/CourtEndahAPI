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
    public class AdminController : ControllerBase
    {
        private readonly BookingContext _context;

        public AdminController(BookingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAdmins()
        {
            return Ok(await _context.ADMIN_Ts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer(CreateAdminRequest createAdminRequest)
        {
            var admin = new ADMIN_T()
            {
                admin_username = createAdminRequest.admin_username,
                admin_password = createAdminRequest.admin_password
            };

            await _context.ADMIN_Ts.AddAsync(admin);
            await _context.SaveChangesAsync();
            return Ok(admin);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAdmin([FromRoute] int id, UpdateAdminRequest updateAdminRequest)
        {
            var admin = await _context.ADMIN_Ts.FindAsync(id);

            if (admin != null)
            {
                admin.admin_password = updateAdminRequest.admin_password;

                await _context.SaveChangesAsync();
                return Ok(admin);
            }

            return NotFound();
        }

    }
}
