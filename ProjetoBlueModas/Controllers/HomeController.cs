using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        /* 
            Páginas
        */
        public IActionResult Index() {
            return View();
        }

        public IActionResult Produto() {
            return View();
        }

        public IActionResult Sobre() {
            return View();
        }

        public IActionResult LoginConvidado() {
            return View();
        }

        public IActionResult LoginUser() {
            return View();
        }

        public IActionResult Cesta() {
            return View();
        }
        /* 
            Fim Páginas
        */


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
