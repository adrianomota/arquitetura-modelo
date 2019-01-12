using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.Infra.Data.EntityConfig;

namespace ProjetoModelo.Infra.Data.Context
{
    public class ProjetoModeloContext : BaseDbContext
    {
        public ProjetoModeloContext()
            : base("ProjetoModelo")
        {
            
        }

        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<Produto> Produtos { get; set; }
        public IDbSet<Endereco> Enderecos { get; set; }
        public IDbSet<Estado> Estados { get; set; }
        public IDbSet<Cidade> Cidades { get; set; }
        public IDbSet<Fornecedor> Fornecedores { get; set; }
        public IDbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Conventions
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            
            // General Custom Context Properties
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            
            // ModelConfiguration
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
