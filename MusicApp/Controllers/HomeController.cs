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
            Mostrar();
            return View();
        }

        [HttpPost]
        public IActionResult Agregar (Cancione canciones) {            
            ViewBag.Bool = true;
            ViewBag.Mensaje = new CrudCLS().Agregar(canciones);
            Mostrar();
            return View("Index");                       
        }
        [HttpPost]
        public IActionResult Editar(Cancione canciones) {
            ViewBag.Bool = true;
            Mostrar();
            return View("Index");            
        }
        [HttpPost]
        public IActionResult Eliminar(int IdCancion) {
            ViewBag.Bool = true;
            ViewBag.Mensaje = new CrudCLS().Eliminar(IdCancion);
            Mostrar();
            return View("Index");
        }
        private void Mostrar() {
            ViewBag.Lista = new CrudCLS().Mostrar();
            if (new CrudCLS().Mostrar().Count < 1)
            {
                ViewBag.mostrar = true;
            }
            else
            {
                ViewBag.mostrar = false;
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}