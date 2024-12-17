using Food1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Food1.Controllers
{
    public class UserController : ApiController
    {
        private bool ValidateUser(string username, string password)
        {
            using (var db = new ApplicationDbContext())
            {
                // Find a user by the username
                var user = db.Users.SingleOrDefault(u => u.Name == username);

                // Check if the user exists and the password matches
                if (user != null && user.Password == password)
                {
                    return true; // User is valid
                }

                return false; // Invalid username or password
            }
        }

        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.Users.Select(u => new
                {
                    u.Id,
                    u.Name,
                    u.Email,
                }).ToList();

                return Ok(users);
            }
        }

        [HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.Users.Select(u => new
                {
                    u.Id,
                    u.Name,
                    u.Email,
                }).Where(model => model.Id == id).ToList();

                return Ok(users);
            }

        }
        
        [HttpPost]
        public IHttpActionResult UserLogin([FromBody] User user)
        {
            // Validate the user's credentials here
            var validUser = ValidateUser(user.Name, user.Password);
            if (validUser)
            {
                return Ok(new { Message = "Login successful!" });
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost]
        [Route("api/User/Create")]
        public IHttpActionResult EmpInsert(User e)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Users.Add(e);
                db.SaveChanges();
                return Ok();
            }

        }
    }
}
