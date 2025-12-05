using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using YourPlatform.IServices;
using YourPlatform.Models;

namespace YourPlatform.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserRegistration UserRegistration;
        public HomeController(IUserRegistration _UserRegistration)
        {
            this.UserRegistration = _UserRegistration;
        }

        public IActionResult Index()
        {
            UserRegister login = new UserRegister();
            return View(login);
        }

        public IActionResult Register(UserRegister user)
        {
            if (ModelState.IsValid) 
            {
                UserRegistration.Register(user);
                return RedirectToAction("HomePage","Home");
            }
            return View("Index", user);
        }
     

        public IActionResult LoginPage()
        {
            Login login= new Login();   
            return View(login);  
              
        }
        [HttpPost]
        public IActionResult SubmitLogin(Login login)
        {
            if(ModelState.IsValid)
            {
               Users user= UserRegistration.Login(login);
                if ((user is null))
                {
                    ModelState.AddModelError(nameof(login.Username), "Wrong username or password");
                    return View("LoginPage", login);
                }
                return RedirectToAction("HomePage", "Home");
            }
            else
            {
             
                return View("LoginPage", login);
            }
          
        }

        public IActionResult HomePage()
        {
            return View();
        }

    }
}
