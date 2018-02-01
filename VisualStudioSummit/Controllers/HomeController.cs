using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VisualStudioSummit.Application;
using VisualStudioSummit.Models;

namespace VisualStudioSummit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AnalisarSentimentos(string arquivo)
        {
            arquivo = arquivo.Replace("data:image/jpeg;base64,", "");

            var arquivoBytes = Convert.FromBase64String(arquivo);

            var emocoes = new ControladorDeEmocoes().DescobrirEmocoes(arquivoBytes);

            return Json(emocoes);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
