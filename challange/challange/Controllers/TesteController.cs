
using challange.Models;
using Microsoft.AspNetCore.Mvc;

namespace challange.Controllers
{
    public  class TesteController : Controller
    {
        public TesteController()
        {
        }

        public IActionResult Index()
        {
            var teste = new Teste();
            teste.Nome = "Abóbora";
            return View(teste);
        }

    }
}
