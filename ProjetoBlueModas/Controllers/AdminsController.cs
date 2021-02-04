using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ProjetoBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Controllers {
    public class AdminsController : Controller {
        // Atributos
        private readonly BlueModasContext _context;
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        string resposta = null;



        // Contrutor
        public AdminsController(BlueModasContext context) {
            _context = context;
        }




        /* Links */
        public async Task<IActionResult> Logout() {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
        /* Fim Link */




        /* Páginas */
        public IActionResult Index() {
            if (User.Identity.IsAuthenticated) {
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        public IActionResult Produtos() {
            if (!User.Identity.IsAuthenticated) {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Historico() {
            if (!User.Identity.IsAuthenticated) {
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Dashboard() {
            if (!User.Identity.IsAuthenticated) {
                return RedirectToAction("Index");
            }
            return View();
        }
        /* Fim Páginas */




        /* Conexão */
        public void connectionString() {
            con.ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
        }
        /* Fim Conexão */




        /* Autenticação */
        [HttpPost]
        public IActionResult Verify(Admin admin) {
            if (!ModelState.IsValid) {
                connectionString();
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from Admins where Email = '" + admin.Email + "' and Senha = '" + admin.Senha + "'";
                dr = com.ExecuteReader();
                if (dr.Read()) {
                    con.Close();
                    Login(admin);
                    return RedirectToAction("Dashboard");
                } else {
                    con.Close();
                    resposta = string.Format("E-mail ou senha estao incorretos. Tente novamente");
                    return View("Index");
                }
            } else {
                return View("Index");
            }
        }

        private async void Login(Admin admin) {
            var claims = new List<Claim> {
                new Claim(ClaimTypes.Name, admin.Email),
                new Claim(ClaimTypes.Role, "Usuario_Comum")
            };

            var identidadeDeUsuario = new ClaimsIdentity(claims, "Name");
            ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(identidadeDeUsuario);

            var propriedadesDeAutenticacao = new AuthenticationProperties {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, propriedadesDeAutenticacao);
        }
        /* Fim Autenticação */
    }
}
