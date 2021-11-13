namespace MiTienda.Ingraestructura.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pav.Tp7.AccesoDatos.MiTiendaContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Pav.Tp7.AccesoDatos.MiTiendaContexto";
        }

        protected override void Seed(Pav.Tp7.AccesoDatos.MiTiendaContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
