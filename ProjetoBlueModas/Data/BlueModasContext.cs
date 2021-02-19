using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoBlueModas.Models;

namespace ProjetoBlueModas.Data {
    public class BlueModasContext : DbContext {
        public BlueModasContext(DbContextOptions<BlueModasContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cesta> Cesta { get; set; }
        public DbSet<Historico> Historico { get; set; }

    }
}
