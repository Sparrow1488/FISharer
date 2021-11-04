using Microsoft.AspNetCore.Mvc;

namespace FISharer.Controllers
{
    public class FilesShare : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
