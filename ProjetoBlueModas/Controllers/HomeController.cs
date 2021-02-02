using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetoBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Controllers {
    public class HomeController : Controller {
        /*private readonly ILogger<HomeController> _logger;*/

        private readonly BlueModasContext _context;

        public HomeController(BlueModasContext context) {
            _context = context;
        }
        /*
                public HomeController(ILogger<HomeController> logger) {
                    _logger = logger;
                }*/

        /* 
            Páginas
        */
        public async Task<IActionResult> Index() {
            return View(await _context.Produtos.ToListAsync());
        }

        public async Task<IActionResult> Produto() {
            return View(await _context.Produtos.ToListAsync());
        }

        public IActionResult Sobre() {
            return View();
        }

        public IActionResult Cesta() {
            return View();
        }
        public IActionResult PedidoRealizado() {
            return View();
        }
        /* 
            Fim Páginas
        */

        /*
            Ações 
        */
        public async Task<IActionResult> InserirNaCesta(int id) {
            if (id == null) {
                return NotFound();
            }


            var produto = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) {
                return NotFound();
            }

            if (!ExisteNaCesta(id)) {
                Inserir(produto.Id, produto); 
            }else {
                return RedirectToRoute(new { controller = "Cestas", action = "Incrementar" });
            }

            return RedirectToAction(nameof(Produto));
        }

        private bool ExisteNaCesta(int id) {
            return _context.Cesta.Any(e => e.Id == id);
        }

        public void Inserir(int id, Produto produto) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "insert into Cesta (ProdutoId) values (@ProdutoId); update Produtos set Quantidade = Quantidade + 1 where id = @ProdutoId";
                    command.Parameters.AddWithValue("@ProdutoId", produto.Id);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }
        /*
            Fim Ações 
        */


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public void mudarElemento(int id, Produto produto, int acao) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    if (acao == 0 && produto.Quantidade > 0) {
                        command.CommandText = "update Produtos set Quantidade = Quantidade - 1 where id = @ProdutoId";
                        command.Parameters.AddWithValue("@ProdutoId", produto.Id);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    } else if (acao == 1) {
                        command.CommandText = "update Produtos set Quantidade = Quantidade + 1 where id = @ProdutoId";
                        command.Parameters.AddWithValue("@ProdutoId", produto.Id);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                }
            }
        }
    }
}
