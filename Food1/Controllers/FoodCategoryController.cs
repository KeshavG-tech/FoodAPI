using Food1.Models;
using System;
using System.Linq;
using System.Web.Http;

namespace Food1.Controllers
{
    public class FoodCategoryController : ApiController
    {
        [HttpGet]
        [Route("api/FoodCategory/{restaurantId}")]
        public IHttpActionResult GetFoodCategoriesByRestaurant(int restaurantId)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Configuration.LazyLoadingEnabled = false;
                // Eagerly load the data by selecting only the relevant fields
                var categories = db.MenuItems
                    .Where(m => m.RestaurantId == restaurantId) // Filter by restaurantId
                    .Select(m => m.FoodCategory) // Select FoodCategory
                    .Distinct() // Get distinct categories
                    .ToList();

                return Ok(categories);
            }
        }
    }
}
