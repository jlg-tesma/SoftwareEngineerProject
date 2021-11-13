namespace MiTienda.Ingraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadesPrimerIteraccion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rubro",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tienda",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sucursal",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TiendaID = c.Int(nullable: false),
                        SucursalNumero = c.Int(nullable: false),
                        Direccion = c.String(nullable: false),
                        TelefonoFijo = c.String(maxLength: 7),
                        TelefonoCodigoArea = c.String(maxLength: 4),
                        EsCasaCentral = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tienda", t => t.TiendaID, cascadeDelete: true)
                .Index(t => t.TiendaID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        TipoEmpleado = c.Int(nullable: false),
                        SucursalID = c.Int(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => new { t.Id, t.NickName })
                .ForeignKey("dbo.Sucursal", t => t.SucursalID)
                .Index(t => t.SucursalID);
            
            CreateTable(
                "dbo.PuntoVenta",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SucursalID = c.Int(nullable: false),
                        PuntoVentaNumero = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sucursal", t => t.SucursalID, cascadeDelete: true)
                .Index(t => t.SucursalID);
            
            AddColumn("dbo.Producto", "RubroId", c => c.Int(nullable: false));
            AddColumn("dbo.Producto", "Talle", c => c.Int(nullable: false));
            AddColumn("dbo.Producto", "MarcaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "RubroId");
            CreateIndex("dbo.Producto", "MarcaId");
            AddForeignKey("dbo.Producto", "MarcaId", "dbo.Marca", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Producto", "RubroId", "dbo.Rubro", "ID", cascadeDelete: true);
            DropColumn("dbo.Producto", "Existencias");
            DropColumn("dbo.Producto", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Producto", "Estado", c => c.Int(nullable: false));
            AddColumn("dbo.Producto", "Existencias", c => c.Int(nullable: false));
            DropForeignKey("dbo.Sucursal", "TiendaID", "dbo.Tienda");
            DropForeignKey("dbo.PuntoVenta", "SucursalID", "dbo.Sucursal");
            DropForeignKey("dbo.Empleado", "SucursalID", "dbo.Sucursal");
            DropForeignKey("dbo.Producto", "RubroId", "dbo.Rubro");
            DropForeignKey("dbo.Producto", "MarcaId", "dbo.Marca");
            DropIndex("dbo.PuntoVenta", new[] { "SucursalID" });
            DropIndex("dbo.Empleado", new[] { "SucursalID" });
            DropIndex("dbo.Sucursal", new[] { "TiendaID" });
            DropIndex("dbo.Producto", new[] { "MarcaId" });
            DropIndex("dbo.Producto", new[] { "RubroId" });
            DropColumn("dbo.Producto", "MarcaId");
            DropColumn("dbo.Producto", "Talle");
            DropColumn("dbo.Producto", "RubroId");
            DropTable("dbo.PuntoVenta");
            DropTable("dbo.Empleado");
            DropTable("dbo.Sucursal");
            DropTable("dbo.Tienda");
            DropTable("dbo.Rubro");
            DropTable("dbo.Marca");
        }
    }
}
