using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelaCadastroEmailsEquipes.Context;
using TelaCadastroEmailsEquipes.Models;

namespace TelaCadastroEmailsEquipes.Controllers
{
    public class EmailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarEquipeEmail(tbl_cadastro model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Cadastros.Add(model);
                    _context.SaveChanges();

                    return RedirectToAction("Cadastro");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ocorreu um erro ao salvar os dados no banco de dados.");
                }
            }

            return View("Cadastro", model);
        }

        public EmailController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Envio()
        {
            var equipes = _context.Cadastros.Select(e => e.equipe).Distinct().ToList();

            ViewBag.Equipes = new SelectList(equipes);

            var emailsAtendimento = _context.EmailAtendimentos.Select(ea => ea.email_atendimento).Distinct().ToList();
            ViewBag.EmailsAtendimento = new SelectList(emailsAtendimento);

            return View();
        }

        [HttpPost]
        public JsonResult ObterEmailsPorEquipe(string equipe)
        {
            var emails = _context.Cadastros
                .Where(e => e.equipe == equipe)
                .Select(e => e.email)
                .ToList();

            return Json(emails);
        }
    }

}