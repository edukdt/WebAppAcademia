using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppAcademia.Models;

namespace WebAppAcademia.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: EmpresaController
        public ActionResult Index()
        {
            return View();
        }
    }
}
