using Microsoft.AspNetCore.Mvc;

namespace WorksManagerMini.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                HttpContext.Session.SetString("user", username);
                return RedirectToAction("Index", "Employees");
            }
            ViewBag.Error = "Username / Password thappu da machan!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}