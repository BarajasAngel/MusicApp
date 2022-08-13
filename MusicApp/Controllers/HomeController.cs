using Microsoft.AspNetCore.Mvc;
using MusicApp.Models;
using System.Diagnostics;

namespace MusicApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Cancione canciones) {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index",canciones);
            }
            return RedirectToAction("Index", canciones);
        }
        [HttpPost]
        public IActionResult Editar(Cancione canciones) {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", canciones);
            }
            return RedirectToAction("Index", canciones);
        }
        [HttpPost]
        public IActionResult Eliminar(int id) {
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}