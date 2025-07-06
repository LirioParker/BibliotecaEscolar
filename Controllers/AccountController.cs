using Microsoft.AspNetCore.Mvc;
using BibliotecaEscolar.Models;

namespace BibliotecaEscolar.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Login simples(simulado)
                if (model.Username == "aluno" && model.Password == "1234")
                {
                    TempData["Mensagem"] = "Login bem sucedido";
                    return RedirectToAction("Index", "Books");
                }

                ModelState.AddModelError(string.Empty, "Usuario ou senha esta errado");
            }

            return View(model);
        }

    }
}
