namespace MiTienda.Ingraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descripcion = c.String(),
                        CostoSinIva = c.Double(nullable: false),
                        PorcentageIva = c.Double(nullable: false),
                        MargenGanancia = c.Double(nullable: false),
                        PrecioFinal = c.Double(nullable: false),
                        Existencias = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Producto");
        }
    }
}
