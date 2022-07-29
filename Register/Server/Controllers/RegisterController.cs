using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Register.Server.Data;
using Register.Shared;

namespace Register.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly RegDataContext _context;

        public RegisterController(RegDataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<Users>>> Reg(Users users)
        {
            users = null;
            _context.User.Add(users);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetUsers()
        {
            var users = await _context.User.Include(sh => sh.Id).ToListAsync();
            return Ok(users);
        }
    }
}
