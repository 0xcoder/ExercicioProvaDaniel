using DanielProva01Exercicio.Context;
using DanielProva01Exercicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DanielProva01Exercicio.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Professor
        public ActionResult Index()
        {
            return View(db.professores.ToList());
        }

        // Cadastro Professor
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfessorModel professorModel)
        {
            if (ModelState.IsValid)
            {
                db.professores.Add(professorModel);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(professorModel);
        }

        

        
    }
}