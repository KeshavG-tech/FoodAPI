using Food1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Food1.Controllers
{
    public class MenuItemController : ApiController
    {
        [HttpGet]
        [Route("api/MenuItem/{restaurantId}/{foodCategoryId}")]
        public IHttpActionResult GetMenuItems(int restaurantId, int foodCategoryId)
        {
            using (var db = new ApplicationDbContext())
            {
                var menuItems = db.MenuItems.Select(u => new
                {
                    u.Id,
                    u.Name,
                    u.Price,
                    u.RestaurantId,
                    u.FoodCategoryId
                })
                    .Where(m => m.RestaurantId == restaurantId && m.FoodCategoryId == foodCategoryId)
                    .ToList();
                return Ok(menuItems);
            }
        }
    }
}
