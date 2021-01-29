using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoBlueModas.Models {
    public class BlueModasContext : DbContext {
        public BlueModasContext(DbContextOptions<BlueModasContext> options) : base(options) {}

    }
}
