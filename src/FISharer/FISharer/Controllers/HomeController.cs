using FISharer.Entities.Clients;
using FISharer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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
            IActionResult result = BadRequest();
            var foundUser = await _userManager.FindByNameAsync(vm.Login);
            if (foundUser != null)
            {
                var authResult = await _signInManager.PasswordSignInAsync(vm.Login, vm.Password, false, false);
                if (authResult.Succeeded)
                    result = Redirect(vm.ReturnUrl);
            }
            return result;
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserViewModel vm)
        {
            IActionResult result = BadRequest();

            var user = new User() { UserName = vm.Login };
            var regResult = await _userManager.CreateAsync(user, vm.Password);
            if (regResult.Succeeded)
            {
                await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Admin"));
                result = Redirect(vm.ReturnUrl);
            }
            return result;
        }
    }
}
