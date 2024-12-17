using Food1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Food1.Controllers
{
    public class UserRoleController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.UserRoles.Select(u => new
                {
                    u.Id,
                    u.UserId,
                    u.Role,
                }).ToList();

                return Ok(users);
            }
        }

        [HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.UserRoles.Select(u => new
                {
                    u.Id,
                    u.UserId,
                    u.Role,
                }).Where(model => model.Id == id).ToList();

                return Ok(users);
            }
        }

        //[HttpPost]
        //public IHttpActionResult GetUserRoles([FromBody] UserRole request)
        //{
        //    using (var db = new ApplicationDbContext())
        //    {
        //        // Get the user roles based on the username
        //        var roles = (from user in db.Users
        //                     join userRole in db.UserRoles on user.Id equals userRole.UserId
        //                     where user.Id == request.UserId
        //                     select userRole.Role).ToList();

        //        return Ok(roles);
        //    }
        //}

    }
}
