using ASPNETMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC5.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente()
            {
                Nome = "Marcelo",
                Sobrenome = "Jaeger",
                DataCadastro = DateTime.Now,
                Id = 1,
            };

            ViewBag.Cliente = cliente;

            return View(cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Nome = "Sueli",
                    Sobrenome = "Santos",
                    DataCadastro = DateTime.Now,
                    Id = 1,
                },new Cliente()
                {
                    Nome = "Maria",
                    Sobrenome = "Geova",
                    DataCadastro = DateTime.Now,
                    Id = 2,
                },new Cliente()
                {
                    Nome = "Ana",
                    Sobrenome = "Santos",
                    DataCadastro = DateTime.Now,
                    Id = 3,
                },
            };    
            return View(listaClientes);
        }
        public ActionResult Pesquisa(int? id, string pesquisa)
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Nome = "Sueli",
                    Sobrenome = "Santos",
                    DataCadastro = DateTime.Now,
                    Id = 1,
                },new Cliente()
                {
                    Nome = "Maria",
                    Sobrenome = "Geova",
                    DataCadastro = DateTime.Now,
                    Id = 2,
                },new Cliente()
                {
                    Nome = "Ana",
                    Sobrenome = "Santos",
                    DataCadastro = DateTime.Now,
                    Id = 3,
                },  new Cliente()
                {
                    Nome = "João",
                    Sobrenome = "Santos",
                    DataCadastro = DateTime.Now,
                    Id = 4,
                },new Cliente()
                {
                    Nome = "Paulo",
                    Sobrenome = "Geova",
                    DataCadastro = DateTime.Now,
                    Id = 5,
                },new Cliente()
                {
                    Nome = "Zé",
                    Sobrenome = "Santos",
                    DataCadastro = DateTime.Now,
                    Id = 6,
                },
            };

            var cliente = listaClientes.Where(c => c.Nome.ToLower().Contains(pesquisa.ToLower())).ToList();

            if (!cliente.Any())
            {
                TempData["erro"] = "Nenhum cliente selecionado";
                return RedirectToAction("ErroPesquisa");
            }
            return View("Lista", cliente);
        }

        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }

    }
}