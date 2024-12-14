using Hamropasal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hamropasal.Controllers
{
    public class UserController : Controller
    {
        public IActionResult StudentList()
        {
            StudentList student = new StudentList("sajan", "kathmandu");
            return View(student);

        }
        public IActionResult UserList()
        {
            User user = new User(1001, "john view", "john@mail.com");
            //sending data to view
            return View(user);
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult DoLogin()
        {

            return View();
        }
        public IActionResult Register()
        {

            return View();
        }
        public IActionResult DoRegister()
        {

            return View();
        }
        public IActionResult ForgotPassword()
        {

            return View();
        }
        public IActionResult ChnagePassword()
        {

            return View();
        }

    }
}
