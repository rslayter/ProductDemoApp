using System.Web.Mvc;

namespace ProductDemoApp.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Products()
        {
            return View();
        }
    }
}