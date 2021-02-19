using ProjetoBlueModas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBlueModas.Data {
    public class ProdutoInserido {
        private readonly BlueModasContext _context;

        public ProdutoInserido(BlueModasContext context) {
            _context = context;
        }

        public void Insere() {
            if (_context.Categoria.Any() || _context.Produtos.Any()) {
                return;
            }

            Categoria c1 = new Categoria("Chapéu");
            Categoria c2 = new Categoria("Camiseta");
            Categoria c3 = new Categoria("Calça");
            Categoria c4 = new Categoria("Tênis");
            Categoria c5 = new Categoria("Bijoteria");

            Produto p1 = new Produto("camiseta1.jfif", 1001, "Camiseta Casual", 50, c2);
            Produto p2 = new Produto("chapeu1.jpg", 1002, "Chapéu Cowboy", 45, c1);
            Produto p3 = new Produto("tenis1.png", 1003, "Tênis Preto", 120, c4);
            Produto p4 = new Produto("biju1.jfif", 1004, "Colar Refino", 400, c5);
            Produto p5 = new Produto("calca1.png", 1005, "Calça Jeans Azul", 130, c3);
            Produto p6 = new Produto("camiseta2.png", 1006, "Camiseta Esportiva", 60, c2);
            Produto p7 = new Produto("calca2.png", 1007, "Calça Jeans Casual", 100, c3);
            Produto p8 = new Produto("chapeu2.jpg", 1008, "Chapéu Casual", 70, c1);
            Produto p9 = new Produto("biju2.jfif", 1009, "Colar Redondo", 350, c5);
            Produto p10 = new Produto("tenis2.jfif", 1010, "Tênis Esportivo", 230, c4);
            Produto p11 = new Produto("calca3.png", 1011, "Calça Jeans Feminino", 120, c3);
            Produto p12 = new Produto("chapeu3.png", 1012, "Chapéu Moderno", 80, c1);
            Produto p13 = new Produto("biju3.png", 1013, "Colar Fino", 605, c5);
            Produto p14 = new Produto("tenis3.jfif", 1014, "Tênis All Star", 135, c4);
            Produto p15 = new Produto("camiseta3.jpg", 1015, "Camiseta Preta", 95, c2);
            Produto p16 = new Produto("tenis4.jfif", 1016, "Tênis Cinza", 225, c4);
            Produto p17 = new Produto("calca4.png", 1017, "Calça Moletom", 215, c3);
            Produto p18 = new Produto("biju4.png", 1018, "Colar de Pedras", 750, c5);
            Produto p19 = new Produto("chapeu4.png", 1019, "Chapéu Feminino", 75, c1);
            Produto p20 = new Produto("calca5.jpg", 1020, "Calça Estilo Militar", 175, c3);

            _context.Categoria.AddRange(
                    c1, c2, c3, c4, c5
            );

            _context.Produtos.AddRange(
                    p1, p2, p3, p4, p5, p6, p7, p8, p9, p10,
                    p11, p12, p13, p14, p15, p16, p17, p18, p19, p20
            );

            _context.SaveChanges();

        }
    }
}
