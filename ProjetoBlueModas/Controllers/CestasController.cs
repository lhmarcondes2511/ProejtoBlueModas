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
    public class CestasController : Controller {
        private readonly BlueModasContext _context;

        public CestasController(BlueModasContext context) {
            _context = context;
        }

        // GET: Cestas
        public async Task<IActionResult> Index() {
            var lista = _context.Cesta.Include(l => l.Produto);
            return View(await lista.ToListAsync());
        }

        // GET: Cestas/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cesta = await _context.Cesta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cesta == null) {
                return NotFound();
            }

            return View(cesta);
        }

        // GET: Cestas/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Cestas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Cesta cesta) {
            if (ModelState.IsValid) {
                _context.Add(cesta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cesta);
        }

        // GET: Cestas/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cesta = await _context.Cesta.FindAsync(id);
            if (cesta == null) {
                return NotFound();
            }
            return View(cesta);
        }

        // POST: Cestas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Cesta cesta) {
            if (id != cesta.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(cesta);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!CestaExists(cesta.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cesta);
        }

        // GET: Cestas/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cesta = await _context.Cesta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cesta == null) {
                return NotFound();
            }

            return View(cesta);
        }

        // POST: Cestas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var cesta = await _context.Cesta.FindAsync(id);
            _context.Cesta.Remove(cesta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CestaExists(int id) {
            return _context.Cesta.Any(e => e.Id == id);
        }

        

        public async Task<IActionResult> DeletarProduto(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cesta = await _context.Cesta.FirstOrDefaultAsync(m => m.Id == id);
            if (cesta == null) {
                return NotFound();
            }

            RemoverProduto(cesta.Id);


            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Incrementar(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cesta = await _context.Cesta.FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (cesta == null) {
                return NotFound();
            }
            mudarElemento(cesta.Id, cesta, 1);

            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Decrementar(int? id) {
            if (id == null) {
                return NotFound();
            }

            var cesta = await _context.Cesta.FirstOrDefaultAsync(m => m.ProdutoId == id);
            if (cesta == null) {
                return NotFound();
            }

            if (cesta.Quantidade > 1) {
                mudarElemento(cesta.Id, cesta, 0);
            } else {
                mudarElemento(cesta.Id, cesta, 3);
            }

            return RedirectToAction(nameof(Index));
        }


        public void mudarElemento(int id, Cesta cesta, int acao) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    if (acao == 0 && cesta.Quantidade > 0) {
                        command.CommandText = "update Cesta set Quantidade = Quantidade - 1 where id = @CestaId";
                        command.Parameters.AddWithValue("@CestaId", id);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    } else if (acao == 1) {
                        command.CommandText = "update Cesta set Quantidade = Quantidade + 1 where id = @CestaId";
                        command.Parameters.AddWithValue("@CestaId", id);
                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                }
            }
        }


        public void RemoverProduto(int id) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "delete from Cesta where id = @CestaId";
                    command.Parameters.AddWithValue("@CestaId", id);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
        }

    }
}