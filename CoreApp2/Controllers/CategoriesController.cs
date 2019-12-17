using Microsoft.AspNetCore.Mvc;

namespace CoreApp2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index(string id)
        {
            // http://localhost:5000/categories/index/ba?magaza=bilgeadam
            //    string page =  Request.Query["magaza"].ToString();

            return View();
        }
    }
}