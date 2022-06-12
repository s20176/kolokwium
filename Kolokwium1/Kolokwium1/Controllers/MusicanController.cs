using Kolokwium1.Models.DTO;
using Kolokwium1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kolokwium1.Controllers
{
    [ApiController]
    [Route("api/musicans")]
    public class MusicanController : ControllerBase
    {
        private readonly IDbService _dbService;

        public MusicanController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getMusican(int id)
        {

            try
            {
                MusicanDTO musican = await _dbService.getMusican(id);
                return Ok(musican);
            }catch(Exception e)
            {
                if(e.Message.Equals("Muzyk nie istnieje"))
                {
                    return NotFound(e.Message);
                }
                return StatusCode(500);
            }
            
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> removeMusican(int id)
        {
            try
            {
                await _dbService.removeMusican(id);
                return Ok("Udało się usunąć muzyka");
            }catch(Exception e)
            {
                if (e.Message.Equals("Nie znaleziono muzyka"))
                {
                    return NotFound(e.Message);
                }
                if (e.Message.Equals("Wszystkie utwory muzyka pojawiły się już na albumach"))
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500);
            }
        }
    }
}
