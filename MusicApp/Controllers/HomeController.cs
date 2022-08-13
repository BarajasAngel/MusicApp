using Microsoft.AspNetCore.Mvc;
using MusicApp.Models;
using System.Diagnostics;
using MusicApp.Clases;
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
            ViewBag.Bool = false;
            ViewBag.Lista = new CrudCLS().Mostrar();
            return View();
        }

        [HttpPost]
        public IActionResult Agregar (Cancione canciones) {            
            ViewBag.Bool = true;
            ViewBag.Mensaje = new CrudCLS().Agregar(canciones);
            ViewBag.Lista = new CrudCLS().Mostrar();
            return View("Index");                       
        }
        [HttpPost]
        public IActionResult Editar(Cancione canciones) {
            ViewBag.Bool = true;
            return View("Index");            
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