using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
namespace API.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
        }

        //api/Users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsersById(int id)
        {
            return _context.Users.Find(id);

        }
    }
}