using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using livraria.Data;
using livraria.Models;

namespace livraria.Controllers
{
    public class livroesController : Controller
    {
        private livrariaContext db = new livrariaContext();
        private static string connectionString { get; set; }

        // GET: livroes
        public ActionResult Index()
        {
            connectionString = ConfigurationManager.ConnectionStrings["dbLivraria"].ToString();
            return View(db.livroes.ToList());
        }

        // GET: livroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            livro livro = db.livroes.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // GET: livroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: livroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LivroID,sISBN,sAutor,sNome,dPreco,dtPublicacao,sImagemCapa,sDescImagemCapa,dtCadastro")] livro livro)
        {
            if (ModelState.IsValid)
            {
                db.livroes.Add(livro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(livro);
        }

        // GET: livroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            livro livro = db.livroes.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: livroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LivroID,sISBN,sAutor,sNome,dPreco,dtPublicacao,sImagemCapa,sDescImagemCapa,dtCadastro")] livro livro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(livro);
        }

        // GET: livroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            livro livro = db.livroes.Find(id);
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: livroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            livro livro = db.livroes.Find(id);
            db.livroes.Remove(livro);
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
