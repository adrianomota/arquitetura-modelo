namespace ProjetoModelo.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cidade", "Estado_EstadoId", c => c.Guid());
            CreateIndex("dbo.Cidade", "Estado_EstadoId");
            AddForeignKey("dbo.Cidade", "Estado_EstadoId", "dbo.Estado", "EstadoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidade", "Estado_EstadoId", "dbo.Estado");
            DropIndex("dbo.Cidade", new[] { "Estado_EstadoId" });
            DropColumn("dbo.Cidade", "Estado_EstadoId");
        }
    }
}
