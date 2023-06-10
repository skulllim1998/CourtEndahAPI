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
    public class BookingController : ControllerBase
    {
        private readonly BookingContext _context;

        public BookingController(BookingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            return Ok(await _context.BOOKING_Ts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingRequest createBookingRequest)
        {
            var booking = new BOOKING_T()
            {
                book_date = createBookingRequest.book_date,
                book_time = createBookingRequest.book_time,
                court_id = createBookingRequest.court_id,
                play_id = createBookingRequest.play_id,
                book_createdate = createBookingRequest.book_createdate,
                book_active = createBookingRequest.book_active
            };

            await _context.BOOKING_Ts.AddAsync(booking);
            await _context.SaveChangesAsync();
            return Ok(booking);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteBooking([FromRoute] int id)
        {
            var booking = await _context.BOOKING_Ts.FindAsync(id);

            if (booking != null)
            {
                booking.book_active = 0;

                await _context.SaveChangesAsync();
                return Ok(booking);
            }

            return NotFound();
        }

        [HttpPut]
        [Route("update/{id:int}")]
        public async Task<IActionResult> UpdateBooking([FromRoute] int id, UpdateBookingRequest updateBookingRequest)
        {
            var booking = await _context.BOOKING_Ts.FindAsync(id);

            if (booking != null)
            {
                booking.book_date = updateBookingRequest.book_date;
                booking.book_time = updateBookingRequest.book_time;
                booking.court_id = updateBookingRequest.court_id;

                await _context.SaveChangesAsync();
                return Ok(booking);
            }

            return NotFound();
        }

    }
}
