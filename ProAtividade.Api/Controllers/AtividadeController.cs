using Microsoft.AspNetCore.Mvc;

namespace ProAtividade.Api.Controllers
{
    public class AtividadeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
