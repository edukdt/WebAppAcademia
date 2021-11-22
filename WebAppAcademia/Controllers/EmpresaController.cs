using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppAcademia.Models;

namespace WebAppAcademia.Controllers
{
    public class EmpresaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }
        public ActionResult Editar()
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

        // POST: EmpresaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return View("Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
