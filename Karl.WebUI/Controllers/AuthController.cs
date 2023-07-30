using Karl.Entities.Concrete;
using Karl.Entities.DTOs.UserDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Karl.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDTO userLoginDTO)
        {
            var findUser = await _userManager.FindByEmailAsync(userLoginDTO.Email);
            if (findUser==null)
            {
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result=await _signInManager.PasswordSignInAsync(findUser, userLoginDTO.Password,true,true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            var user = await _userManager.FindByEmailAsync(userRegisterDTO.Email);
            if (user != null)
            {
                return View();
            }

            User newUser = new()
            {
                FirstName=userRegisterDTO.FirstName,
                LastName=userRegisterDTO.LastName,
                Email=userRegisterDTO.Email,
                Address="",
                UserName=userRegisterDTO.Email
            };

            var result = _userManager.CreateAsync(newUser,userRegisterDTO.Password);

            if (result.Succeeded)
            {
                await _signInManager.PasswordSignInAsync(newUser, userRegisterDTO.Password, true, true);
                return RedirectToAction("Index", "Home");
            }
 

            return View();
        }
    }
}
