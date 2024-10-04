using Microsoft.AspNetCore.Mvc;

namespace NiceNiceShop.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(int? loai )
        {
            return View();
        }
    }
}
