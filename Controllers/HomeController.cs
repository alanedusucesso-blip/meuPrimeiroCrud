using System.Diagnostics;
using meuprimeirocrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace meuprimeirocrud.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Usuario usuario = new Usuario();

            usuario.Nome = "Alan";
            usuario.senha = "123456";
            return View(usuario);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
