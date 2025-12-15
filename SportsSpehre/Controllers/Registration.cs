using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsSpehre.Context;

namespace SportsSpehre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Registration : ControllerBase
    {
        private DapperContext _context;
        private object registration;

        public Registration(DapperContext context)
        {
            _context = context;
        }
        [HttpGet("GetAllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            try
            {
                var registration = await _context.CreateConnection().QueryAsync("SELECT * FROM Registration");
                return Ok(registration);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    
}
