using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoBlueModas.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using ProjetoBlueModas.Data;

namespace ProjetoBlueModas.Controllers {
    public class ProdutosController : Controller {
        private readonly BlueModasContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public ProdutosController(BlueModasContext context, IWebHostEnvironment webHostEnvironment) {
            _context = context;
            this._webHostEnvironment = webHostEnvironment;
        }

        /* Páginas */
        public async Task<IActionResult> Index() {
            return View(await _context.Produtos.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) {
                return NotFound();
            }

            return View(produto);
        }
        public IActionResult Create() {
            ViewData["CategoriaNome"] = new SelectList(_context.Categoria, "Id", "Nome");
            return View();
        }
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null) {
                return NotFound();
            }
            return View(produto);
        }
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) {
                return NotFound();
            }

            return View(produto);
        }
        /* Fim Páginas */







        /* Ações */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Img,Codigo,Nome,QuantidadeMaxima,Preco,CategoriaId")] Produto produto) {
            if (ModelState.IsValid && produto.Img != null) {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(produto.Img.FileName);
                string extension = Path.GetExtension(produto.Img.FileName);
                produto.Imagem = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create)) {
                    await produto.Img.CopyToAsync(fileStream);
                }
                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Message = "Complete todos os campos, tente novamente";
            ViewData["CategoriaNome"] = new SelectList(_context.Categoria, "Id", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Imagem,Codigo,Nome,QuantidadeMaxima,Preco,CategoriaId")] Produto produto) {
            if (id != produto.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!ProdutoExists(produto.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var produto = await _context.Produtos.FindAsync(id);

            var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Image", produto.Imagem);
            if (System.IO.File.Exists(imagePath)) {
                System.IO.File.Delete(imagePath);
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id) {
            return _context.Produtos.Any(e => e.Id == id);
        }
        /* Fim Ações */


    }
}
