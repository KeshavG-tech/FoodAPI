using Food1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Food1.Controllers
{
    public class RestaurantController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAllRestaurants()
        {
            using (var db = new ApplicationDbContext())
            {
                var restaurants = db.Restaurants.Select(u => new
                {
                    u.Id,
                    u.Name,
                    u.Address,
                }).ToList();
                
                return Ok(restaurants);
            }
        }
    }
}
