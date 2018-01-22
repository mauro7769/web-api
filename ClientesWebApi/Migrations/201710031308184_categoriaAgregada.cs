namespace ClientesWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoriaAgregada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Clientes", "CategoriaId", c => c.Int());
            CreateIndex("dbo.Clientes", "CategoriaId");
            AddForeignKey("dbo.Clientes", "CategoriaId", "dbo.Categorias", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Clientes", new[] { "CategoriaId" });
            DropColumn("dbo.Clientes", "CategoriaId");
            DropTable("dbo.Categorias");
        }
    }
}
