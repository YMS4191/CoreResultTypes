using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreApp2.Controllers
{

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
    public class HomeController : Controller
    {
        #region ViewResult
        public ViewResult Index(string q)
        {
            if (q != null)
            {
                if (q == "error")
                {
                    return View("error");
                }
                return View("ara");
            }
            return View();
        }
        #endregion

        #region JsonResult
        public JsonResult Json()
        {
            var json_data = new List<Category>() {
               new Category      {
                      CategoryID = 1,
                      CategoryName = "Beverages",
                      Description = "Soft drinks, coffees, teas, beers, and ales"
                },
                 new Category
                 {
                     CategoryID = 2,
                     CategoryName = "Condiments",
                     Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
                 },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Confections",
                    Description = "Desserts, candies, and sweet breads"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Dairy Products",
                    Description = "Cheeses"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Grains/Cereals",
                    Description = "Breads, crackers, pasta, and cereal"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Meat/Poultry",
                    Description = "Prepared meats"
                },
               new Category
               {
                   CategoryID = 7,
                   CategoryName = "Produce",
                   Description = "Dried fruit and bean curd"
               },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Seafood",
                    Description = "Seaweed and fish"
                }};

            return Json(json_data);
        }
        #endregion

        #region RedirectToActionResult
        public RedirectToActionResult About()
        {
            return RedirectToAction("Contact");
        }
        #endregion

        #region RedirectResult
        public RedirectResult Contact()
        {
            return Redirect("https://www.google.com/");
        }
        #endregion

        #region NotFoundResult
        public NotFoundResult Bulunamadi()
        {
            return NotFound();
        }
        #endregion

        #region UnauthorizedResult
        public UnauthorizedResult Login()
        {
            return Unauthorized();
        }
        #endregion

        #region Örnek
        public ViewResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            // db.Categories.Add(category);
            //bool result = db.SaveChanges() > 0;
            bool result = true;

            Category category = new Category(); // arayüzden gelen data
            if (category == null)
            {
                return NotFound();
            }

            if (result)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        #endregion


        //public IActionResult ara()
        //{
        //    return View();
        //}
    }
}

// ViewResult             => Html web sayfası View teslim eder, geriye sadece View dönebilirsiniz.
// JsonResult             => json objesi teslim eder.
// RedirectToActionResult => Action içerisinde işlem sonunda kullanıcıyı farklı bir Action'a yönlendirebilirsiniz.
// RedirectResult         => Kullanıcıyı harici bir siteye yönlendirecekseniz kullanabilirsiniz.
// NotFoundResult         => 404 hatası teslim eder, aradığınız değere ulaşılamıyor ise, kullanıcıyı yönlendiririz.
// UnauthorizedResult     => Sayfaya erişmek için kimlik doğrulaması yapmanız gerektiği anlamına gelir,