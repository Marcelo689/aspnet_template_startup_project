using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNETMVC5.Context;
using ASPNETMVC5.Models;

namespace ASPNETMVC5.Controllers
{
    public class ClientesController : Controller
    {
        private Aula1Context db = new Aula1Context();

        //[ValidateInput(false)] remove a segurança, fazendo ser possivel receber dados não seguros por requisição

        [OutputCache(Duration = 30, VaryByParam = "*")]
        public ContentResult TesteContent()
        {
            return Content(DateTime.Now.ToString());
        }
        public ActionResult TesteCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TesteCreate([Bind(Include = "Id,Nome,Sobrenome,DataCadastro,QuerCertificado,Email")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.DataCadastro = DateTime.Now;
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }
        public ActionResult TesteActionsResult()
        {
            //return Json(db.Clientes.ToList(), JsonRequestBehavior.AllowGet);
            //return Content("Saida teste");
            //return JavaScript("<script>alert('printando isso!')</script>");


            //var myfile = System.IO.File.ReadAllBytes("wwwroot/Files/FileContentResult.pdf");
            //return new FileContentResult(myfile, "application/pdf");
            //return File(myfile, "application/pdf");
            return new HttpUnauthorizedResult();
        }
        public ActionResult Teste()
        {
            var lista = db.Clientes.ToList();
            ViewBag.Ola = "<h2>batata</h2>";
            ViewBag.Id = new SelectList(lista, "Id", "Nome", 1);
            return View(lista);
        }
        // GET: Clientes

        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Sobrenome,DataCadastro,QuerCertificado,Email")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (!cliente.Email.Contains(".br"))
                {
                    ModelState.AddModelError(String.Empty, "Email não pode ser internacional!");
                    return View(cliente);
                }
                cliente.DataCadastro = DateTime.Now;
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,DataCadastro")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            //db.Clientes.Remove(cliente);
            //db.SaveChanges();
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
