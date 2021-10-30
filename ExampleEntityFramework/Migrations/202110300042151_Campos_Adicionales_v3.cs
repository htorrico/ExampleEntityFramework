namespace ExampleEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Campos_Adicionales_v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Apellidos", c => c.String());
            AddColumn("dbo.DetalleFacturas", "Cantidad", c => c.Int(nullable: false));
            AddColumn("dbo.DetalleFacturas", "SubTotal", c => c.Int(nullable: false));
            AddColumn("dbo.Productoes", "Descripcion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "Descripcion");
            DropColumn("dbo.DetalleFacturas", "SubTotal");
            DropColumn("dbo.DetalleFacturas", "Cantidad");
            DropColumn("dbo.Clientes", "Apellidos");
        }
    }
}
