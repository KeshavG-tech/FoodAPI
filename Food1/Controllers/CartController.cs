using Food1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Food1.Controllers
{
    public class CartController : ApiController
    {
        [HttpGet]
        public IHttpActionResult cart()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.cartItems.Select(u => new
                {
                    u.UserId,
                    u.Name,
                    u.Price,
                    u.Quantity,
                }).ToList();

                return Ok(users);
            }
        }

        [HttpPost]
        public IHttpActionResult EmpInsert(CartItem e)
        {
            using (var db = new ApplicationDbContext())
            {
                db.cartItems.Add(e);
                db.SaveChanges();
                return Ok();
            }

        }
    }
}
