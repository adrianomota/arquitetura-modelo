namespace ProjetoModelo.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        CidadeId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        EstadoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.CidadeId)
                .ForeignKey("dbo.Estado", t => t.EstadoId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        EstadoId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        UF = c.String(nullable: false, maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Sobrenome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        CPF = c.String(nullable: false, maxLength: 11, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoId = c.Guid(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 150, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 100, unicode: false),
                        Complemento = c.String(nullable: false, maxLength: 100, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        CEP = c.String(nullable: false, maxLength: 8, unicode: false),
                        EstadoId = c.Guid(nullable: false),
                        CidadeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.Cidade", t => t.CidadeId)
                .ForeignKey("dbo.Estado", t => t.EstadoId)
                .Index(t => t.EstadoId)
                .Index(t => t.CidadeId);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        FornecedorId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        CNPJ = c.String(nullable: false, maxLength: 14, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FornecedorId);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        VendaId = c.Guid(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataCadastro = c.DateTime(nullable: false),
                        TipoVenda = c.Int(nullable: false),
                        ClienteId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponivel = c.Boolean(nullable: false),
                        FornecedorId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Fornecedor", t => t.FornecedorId)
                .Index(t => t.FornecedorId);
            
            CreateTable(
                "dbo.EnderecosFornecedor",
                c => new
                    {
                        FornecedorId = c.Guid(nullable: false),
                        EnderecoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.FornecedorId, t.EnderecoId })
                .ForeignKey("dbo.Fornecedor", t => t.FornecedorId)
                .ForeignKey("dbo.Endereco", t => t.EnderecoId)
                .Index(t => t.FornecedorId)
                .Index(t => t.EnderecoId);
            
            CreateTable(
                "dbo.EnderecosCliente",
                c => new
                    {
                        ClienteId = c.Guid(nullable: false),
                        EnderecoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClienteId, t.EnderecoId })
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .ForeignKey("dbo.Endereco", t => t.EnderecoId)
                .Index(t => t.ClienteId)
                .Index(t => t.EnderecoId);
            
            CreateTable(
                "dbo.VendaProdutos",
                c => new
                    {
                        VendaId = c.Guid(nullable: false),
                        ProdutoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.VendaId, t.ProdutoId })
                .ForeignKey("dbo.Venda", t => t.VendaId)
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .Index(t => t.VendaId)
                .Index(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VendaProdutos", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.VendaProdutos", "VendaId", "dbo.Venda");
            DropForeignKey("dbo.Produto", "FornecedorId", "dbo.Fornecedor");
            DropForeignKey("dbo.Venda", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.EnderecosCliente", "EnderecoId", "dbo.Endereco");
            DropForeignKey("dbo.EnderecosCliente", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.EnderecosFornecedor", "EnderecoId", "dbo.Endereco");
            DropForeignKey("dbo.EnderecosFornecedor", "FornecedorId", "dbo.Fornecedor");
            DropForeignKey("dbo.Endereco", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.Endereco", "CidadeId", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "EstadoId", "dbo.Estado");
            DropIndex("dbo.VendaProdutos", new[] { "ProdutoId" });
            DropIndex("dbo.VendaProdutos", new[] { "VendaId" });
            DropIndex("dbo.EnderecosCliente", new[] { "EnderecoId" });
            DropIndex("dbo.EnderecosCliente", new[] { "ClienteId" });
            DropIndex("dbo.EnderecosFornecedor", new[] { "EnderecoId" });
            DropIndex("dbo.EnderecosFornecedor", new[] { "FornecedorId" });
            DropIndex("dbo.Produto", new[] { "FornecedorId" });
            DropIndex("dbo.Venda", new[] { "ClienteId" });
            DropIndex("dbo.Endereco", new[] { "CidadeId" });
            DropIndex("dbo.Endereco", new[] { "EstadoId" });
            DropIndex("dbo.Cidade", new[] { "EstadoId" });
            DropTable("dbo.VendaProdutos");
            DropTable("dbo.EnderecosCliente");
            DropTable("dbo.EnderecosFornecedor");
            DropTable("dbo.Produto");
            DropTable("dbo.Venda");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
        }
    }
}
