using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POS_DeportShop.Models;

namespace POS_DeportShop.Data
{
    public class POS_DeportShopContext : DbContext
    {
        public POS_DeportShopContext (DbContextOptions<POS_DeportShopContext> options)
            : base(options)
        {
        }
        
        public DbSet<POS_DeportShop.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<POS_DeportShop.Models.Sucursal>? Sucursal { get; set; }

        public DbSet<POS_DeportShop.Models.Proveedor>? Proveedor { get; set; }

        public DbSet<POS_DeportShop.Models.LogUsuario>? LogUsuario { get; set; }

        public DbSet<POS_DeportShop.Models.Categoria>? Categoria { get; set; }

        public DbSet<POS_DeportShop.Models.AtributoGrupo>? AtributoGrupo { get; set; }

        public DbSet<POS_DeportShop.Models.Atributo>? Atributo { get; set; }

        public DbSet<POS_DeportShop.Models.Marca>? Marca { get; set; }

        public DbSet<POS_DeportShop.Models.Cliente>? Cliente { get; set; }
    }
}
