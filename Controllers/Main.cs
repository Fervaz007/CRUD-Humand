using Microsoft.AspNetCore.Mvc;

namespace CRUD_Humand.Controllers
{
    public class Main : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
