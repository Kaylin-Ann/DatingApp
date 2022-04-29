using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    //attributes for controller
    [ApiController]
    [Route("api/[controller]")] //start with api
    public class UsersController : ControllerBase
    {
        //getting data from database - using dependency injection
        // - generating a constructor (hover in userscontroller name)
        private readonly DataContext _context; //(get this from initizing field from parameter - ctrl. on context)
        public UsersController(DataContext context)
        {
            _context = context;
        }

        //Adding two endpoints
        [HttpGet]
        //making the code  ASYCHRONOUS 
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //list of users
        {
            /*var users = _context.Users.ToList();
            return users;*/
            
            //OR

            return await _context.Users.ToListAsync();
        }

        //getting an individual user by their ID
        //api/users/3 - example
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}