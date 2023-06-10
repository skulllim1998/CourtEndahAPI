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
    public class PlayerController : ControllerBase
    {
        private readonly BookingContext _context;

        public PlayerController(BookingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            return Ok(await _context.PLAYER_Ts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer(CreatePlayerRequest createPlayerRequest)
        {
            var player = new PLAYER_T()
            {
                play_username = createPlayerRequest.play_username,
                play_password = createPlayerRequest.play_password,
                play_fullname = createPlayerRequest.play_fullname,
                play_unitno = createPlayerRequest.play_unitno,
                play_cardno = createPlayerRequest.play_cardno,
                play_createdate = createPlayerRequest.play_createdate,
                play_active = createPlayerRequest.play_active
            };

            await _context.PLAYER_Ts.AddAsync(player);
            await _context.SaveChangesAsync();
            return Ok(player);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdatePlayer([FromRoute] int id, UpdatePlayerRequest updatePlayerRequest)
        {
            var player = await _context.PLAYER_Ts.FindAsync(id);

            if (player != null)
            {
                player.play_password = updatePlayerRequest.play_password;
                player.play_fullname = updatePlayerRequest.play_fullname;
                player.play_unitno = updatePlayerRequest.play_unitno;
                player.play_cardno = updatePlayerRequest.play_cardno;

                await _context.SaveChangesAsync();
                return Ok(player);
            }

            return NotFound();
        }

        [HttpPut]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> DeletePlayer([FromRoute] int id)
        {
            var player = await _context.PLAYER_Ts.FindAsync(id);

            if (player != null)
            {
                player.play_active = 0;

                await _context.SaveChangesAsync();
                return Ok(player);
            }

            return NotFound();
        }

        [HttpPut]
        [Route("active/{id:int}")]
        public async Task<IActionResult> ActivePlayer([FromRoute] int id)
        {
            var player = await _context.PLAYER_Ts.FindAsync(id);

            if (player != null)
            {
                player.play_active = 1;

                await _context.SaveChangesAsync();
                return Ok(player);
            }

            return NotFound();
        }

    }
}
