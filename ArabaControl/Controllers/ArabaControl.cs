using Microsoft.AspNetCore.Mvc;

namespace ArabaControl.Controllers
{
    public class ArabaControl : Controller
    {
        public IActionResult Index()
        {
            return Json(new
            {
                Id = 1,
                Seviye = "ChpyerTruck",
                MarkaAdi = "Tesla"
            });
        }
    }
}
