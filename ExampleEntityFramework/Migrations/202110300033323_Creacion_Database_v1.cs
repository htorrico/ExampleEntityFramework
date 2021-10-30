namespace ExampleEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creacion_Database_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.DetalleFacturas",
                c => new
                    {
                        DetalleFacturaID = c.Int(nullable: false, identity: true),
                        FacturaID = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleFacturaID)
                .ForeignKey("dbo.Facturas", t => t.FacturaID, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.FacturaID)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        FacturaID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Numero = c.String(),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FacturaID)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Precio = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ProductoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleFacturas", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.DetalleFacturas", "FacturaID", "dbo.Facturas");
            DropForeignKey("dbo.Facturas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Facturas", new[] { "ClienteId" });
            DropIndex("dbo.DetalleFacturas", new[] { "ProductoId" });
            DropIndex("dbo.DetalleFacturas", new[] { "FacturaID" });
            DropTable("dbo.Productoes");
            DropTable("dbo.Facturas");
            DropTable("dbo.DetalleFacturas");
            DropTable("dbo.Clientes");
        }
    }
}
