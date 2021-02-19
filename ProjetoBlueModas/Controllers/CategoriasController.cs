﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoBlueModas.Data;
using ProjetoBlueModas.Models;

namespace ProjetoBlueModas.Controllers {
    public class CategoriasController : Controller {
        private readonly BlueModasContext _context;

        public CategoriasController(BlueModasContext context) {
            _context = context;
        }

        /* Páginas */
        public async Task<IActionResult> Index() {
            return View(await _context.Categoria.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var categoria = await _context.Categoria.FirstOrDefaultAsync(m => m.Id == id);
            if (categoria == null) {
                return NotFound();
            }

            return View(categoria);
        }
        public IActionResult Create() {
            return View();
        }
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null) {
                return NotFound();
            }
            return View(categoria);
        }
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var categoria = await _context.Categoria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoria == null) {
                return NotFound();
            }

            return View(categoria);
        }
        /* Fim Páginas */

        /* Ações */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Categoria categoria) {
            if (ModelState.IsValid) {
                _context.Add(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] Categoria categoria) {
            if (id != categoria.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(categoria);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!CategoriaExists(categoria.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var categoria = await _context.Categoria.FindAsync(id);

            if (VerificarProduto(categoria.Id) == true) {
                ViewBag.Message = String.Format("Nao pode ser excluido, pois ele esta relacionado com um Produto");
                return View(categoria);
            } else {
                _context.Categoria.Remove(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
        public bool VerificarProduto(int id) {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=bluemodas;Trusted_Connection=True;";
            var result = 0;
            using (SqlConnection conn = new SqlConnection(connection)) {
                conn.Open();
                using (SqlCommand command = new SqlCommand("", conn)) {
                    command.CommandText = "select COUNT(*) from Produtos where CategoriaId = @id;";
                    command.Parameters.AddWithValue("@id", id);
                    result = (int)command.ExecuteScalar();
                    command.Dispose();
                }
                if (result >= 1) {
                    return true;
                }
                return false;
            }
        }
        private bool CategoriaExists(int id) {
            return _context.Categoria.Any(e => e.Id == id);
        }
        /* Fim Ações */



    }
}
