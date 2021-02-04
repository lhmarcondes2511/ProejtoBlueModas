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
        private readonly BlueModasContext _context;
        long protocolo = 0;
        string resposta;

        public HomeController(BlueModasContext context) {
            _context = context;
        }


        /* 
            Páginas
        */
        public IActionResult Index() {
            var produto = _context.Produtos.Include(x => x.Categoria).Where(x => x.Categoria.Id == x.CategoriaId).ToList().Take(3);
            return View(produto);
        }

        public async Task<IActionResult> Produto(string nome, string categoria) {
            var produtos = await _context.Produtos.Include(x => x.Categoria).Where(x => x.Categoria.Id == x.CategoriaId).ToListAsync();


            if (!String.IsNullOrEmpty(nome)) {
                produtos = (List<Produto>)produtos.Where(s => s.Nome.ToLower().Contains(nome.ToLower()));
            }

            if (!String.IsNullOrEmpty(categoria)) {
                produtos = await _context.Produtos.Include(x => x.Categoria).Where(x => x.Categoria.Nome.ToLower() == categoria.ToLower()).ToListAsync();
            }

            return View(produtos);
        }

        public IActionResult Sobre() {
            return View();
        }

        public IActionResult Cesta() {
            return View();
        }
        public IActionResult PedidoRealizado() {
            IEnumerable<Historico> historico = (from h in _context.Historico join c in _context.Cesta on h.CestaId equals c.Id select h);
            return View(historico);
        }
        /* 
            Fim Páginas
        */



        /*
            Ações 
        */
        public async Task<IActionResult> FecharPedidoRealizado() {
            var cesta = await _context.Cesta.ToListAsync();
            var cliente = await _context.Clientes.ToListAsync();
            if (cesta == null && cliente == null) {
                return NotFound();
            }

            limparCestaECliente();

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        public void limparCestaECliente() {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "delete from Clientes; delete from Cesta;";
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }

        public async Task<IActionResult> InserirNaCesta(int? id) {
            if (id == null) {
                return NotFound();
            }

            
            var produto = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) {
                return NotFound();
            }

            if (ElementoCesta()) {
                var cesta = await _context.Cesta.FirstOrDefaultAsync();
                if (!ExisteNaCesta(produto.Id)) {
                    resposta = "alert alert-success alert-dismissible show";
                    Inserir(produto.Id, cesta.Protocolo);
                }else {
                    mudarElemento(produto.Id);
                    resposta = "alert alert-success alert-dismissible show";
                }
            } else {
                var cesta = await _context.Cesta.FirstOrDefaultAsync();
                DateTime data = DateTime.Now;
                Random rand = new Random();
                protocolo = long.Parse(data.ToString("yyyyMMdd") + rand.Next(1000, 9999));
                if (!ExisteNaCesta(produto.Id)) {
                    Inserir(produto.Id, protocolo);
                } else {
                    mudarElemento(produto.Id);
                }
            }

            return RedirectToAction(nameof(Produto));
        }

        private bool ExisteNaCesta(int id) {
            return _context.Cesta.Any(e => e.Produto.Id == id);
        }

        public void mudarElemento(int id) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "update Cesta set Quantidade = Quantidade + 1 where ProdutoId = @ProdutoId";
                    command.Parameters.AddWithValue("@ProdutoId", id);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }

        public bool ElementoCesta() {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            var result = 0;
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "select COUNT(*) from Cesta;";
                    result = (int)command.ExecuteScalar();
                    command.Dispose();
                }
                if (result >= 1) {
                    return true;
                }
                return false;
            }
        }

        public void Inserir(int id, long protocolo) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "insert into Cesta (ProdutoId, Protocolo) values (@ProdutoId, @Protocolo); update Cesta set Quantidade = Quantidade + 1 where ProdutoId = @ProdutoId;";
                    command.Parameters.AddWithValue("@ProdutoId", id);
                    command.Parameters.AddWithValue("@Protocolo", protocolo);
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
    }
}
