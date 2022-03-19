using Parcial01.Bussines;
using Parcial01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorio01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static readonly Operaciones op = new Operaciones();
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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


        public IActionResult Retiro(Acciones acciones)
        {
            ViewBag.MontoV1 = acciones.Monto;
            

            if (acciones.Monto % 5 == 0)
            {


            }
            else
            {
                return View("Fallo2");
            }

            return View();


           
        }


        public IActionResult Error2() { return View(); }


        public IActionResult Exito() { return View(); }

        [HttpGet]
        public IActionResult PeticionTypeGet()
        {
            return View();
        }
    }
}