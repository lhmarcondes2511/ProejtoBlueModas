using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoBlueModas.Models;

namespace ProjetoBlueModas.Controllers {
    public class HistoricoesController : Controller {
        private readonly BlueModasContext _context;

        public HistoricoesController(BlueModasContext context) {
            _context = context;
        }

        // GET: Historicoes
        public async Task<IActionResult> Index(string protocolo, string codigo, string nomeCliente, string nomeProduto) {
            var historico = from m in _context.Historico select m;

            if (protocolo != null) {
                historico = historico.Where(s => s.Protocolo.ToString().Contains(protocolo));
            }
            if (!String.IsNullOrEmpty(nomeCliente)) {
                historico = historico.Where(s => s.NomeCliente.ToLower().Contains(nomeCliente.ToLower()));
            }
            if (!String.IsNullOrEmpty(nomeProduto)) {
                historico = historico.Where(s => s.NomeProduto.ToLower().Contains(nomeProduto.ToLower()));
            }


            return View(historico);
        }

        // GET: Historicoes/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var historico = await _context.Historico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historico == null) {
                return NotFound();
            }

            return View(historico);
        }

        // GET: Historicoes/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Historicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Historico historico) {
            if (ModelState.IsValid) {
                _context.Add(historico);
                await _context.SaveChangesAsync();
                return RedirectToRoute(new { controller = "Clientes", action = "Index" });
            }
            return View(historico);
        }

        public async Task<IActionResult> InserirCesta () {
            var cesta = await _context.Cesta.ToListAsync();
            if(cesta == null) {
                return NotFound();
            }

            InserirCestaNoHistorico();

            return RedirectToRoute(new { controller = "Clientes", action = "Index" });
        }
        public void InserirCestaNoHistorico() {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "insert into Historico ( CestaId, Protocolo, CodigoProduto, ImagemProduto, NomeProduto, PrecoProduto, NomeCategoria, QuantidadeCesta) SELECT C.Id, C.Protocolo, P.Codigo, P.Imagem, P.Nome, P.Preco, CA.Nome, C.Quantidade FROM Cesta C INNER JOIN Produtos P ON C.ProdutoId = P.Id INNER JOIN Categoria CA ON CA.Id = P.CategoriaId";
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }


        // GET: Historicoes/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var historico = await _context.Historico.FindAsync(id);
            if (historico == null) {
                return NotFound();
            }
            return View(historico);
        }

        // POST: Historicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Historico historico) {
            if (id != historico.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(historico);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!HistoricoExists(historico.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(historico);
        }

        // GET: Historicoes/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var historico = await _context.Historico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historico == null) {
                return NotFound();
            }

            return View(historico);
        }

        // POST: Historicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var historico = await _context.Historico.FindAsync(id);
            _context.Historico.Remove(historico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoExists(int id) {
            return _context.Historico.Any(e => e.Id == id);
        }
    }
}
