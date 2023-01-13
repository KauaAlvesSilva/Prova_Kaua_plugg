using Microsoft.AspNetCore.Mvc;
using Prova_Kauã.Models;
using System.Diagnostics;

namespace Prova_Kauã.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("kaua")]
        public IActionResult kaua()
        {
            return View();
        }
        public bool Login(UsuarioViewModel model)
        {
            try
            {
                if (model.EMAIL.ToLower() == "prova" && model.SENHA.ToLower() == "prova123")
                    return true;

                else
                    return false;

            }
            catch (Exception ex)        
            {
                return false;
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}