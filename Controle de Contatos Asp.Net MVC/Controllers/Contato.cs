using Microsoft.AspNetCore.Mvc;

namespace Controle_de_Contatos_Asp.Net_MVC.Controllers
{
    public class Contato : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }


        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}
