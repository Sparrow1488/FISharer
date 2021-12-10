using FISharer.Entities.Clients;
using FISharer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FISharer.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel vm)
        {
            vm.ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            //var user = new User() { UserName = vm.Login };
            //var result = await _userManager.CreateAsync(user, vm.Password);
            return Redirect(vm.ReturnUrl);
        }
    }
}
