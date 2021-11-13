using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7.AccesoDatos
{
    class MiTiendaContexto : DbContext
    {
        public MiTiendaContexto():base("MiTienda")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
    }
}
