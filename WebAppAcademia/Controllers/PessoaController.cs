using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppAcademia.Models;

namespace WebAppAcademia.Controllers
{
    public class PessoaController : Controller
    {
        // GET: PessoaController
        public ActionResult Index()
        {
            return View(new PessoaModel()
            {
                Id = 1,
                NomeCompleto = "Um dois três de Oliveira Quatro",
                PrimeiroNome = "Um dois três",
                Sobrenome = "de Oliveira Quatro",
                Email = "oliveira4@outlook.com",
                Login = "123oliveira4",
                DataNascimento = DateTime.Now,
                QuantidadeFilhos = 0
            });
        }

        // GET: PessoaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PessoaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PessoaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PessoaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PessoaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PessoaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PessoaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
