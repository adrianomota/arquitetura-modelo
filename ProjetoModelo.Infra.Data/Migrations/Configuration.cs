using System;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ProjetoModeloContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ProjetoModeloContext context)
        {
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("D03B8317-9DCD-4C61-81C5-B175C4998FE3"), UF = "AC", Nome = "Acre"} );
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("C3980EF8-3301-4EB1-9A23-4B1CEBE72D54"), UF = "AL", Nome = "Alagoas"});        
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("B83A4013-975A-4084-B83F-294662154F23"), UF = "AP", Nome = "Amapá"});    
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("6D3F9E3F-C344-4C19-BA5C-FBB56EEFAA11"), UF = "AM", Nome = "Amazonas"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("0907D056-5B2E-4509-B01D-8D75F280FB37"), UF = "BA", Nome = "Bahia"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("817DB637-D7F9-4426-89F3-D31996A35E25"), UF = "CE", Nome = "Ceará"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("2C10406D-D15C-4537-908F-E950D3881C32"), UF = "DF", Nome = "Distrito Federal"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("35A0A613-534C-42EF-8BD8-ABC38E9EBD6E"), UF = "GO", Nome = "Goiás"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("98CD5D5A-7340-4F0F-BEC9-FA444230E415"), UF = "ES", Nome = "Espírito Santo"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("588EF569-442D-422D-97EA-81F547691173"), UF = "MA", Nome = "Maranhão"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("AC3A45AD-AA9A-409E-BD86-9E1EF9A0EE32"), UF = "MT", Nome = "Mato Grosso"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("1892BFA2-BABB-44B8-AECC-09897466E99F"), UF = "MS", Nome = "Mato Grosso do Sul"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("C52CF806-286A-4BCE-9091-4903848A104A"), UF = "MG", Nome = "Minas Gerais"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("CB465154-8980-4018-B5E9-99C6333007A8"), UF = "PA", Nome = "Pará"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("6183E867-4D94-4680-A24D-4DEC071CD454"), UF = "PB", Nome = "Paraiba"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("27868D65-0D8A-4337-AB1C-1A1C87D2AED6"), UF = "PR", Nome = "Paraná"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("3FE4555D-FF71-47D8-8F3F-3AFA05D1B224"), UF = "PE", Nome = "Pernambuco"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("C48572B1-FA62-404D-8C53-D76A2825593B"), UF = "PI", Nome = "Piauí­"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("F55131B9-26AD-4ECC-A189-AAF9FA01F283"), UF = "RJ", Nome = "Rio de Janeiro"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("66CF991B-CA46-4F08-BA34-9640B4C9275F"), UF = "RN", Nome = "Rio Grande do Norte"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("75C9E05E-6EBF-4180-BF37-C4A15E2B80CE"), UF = "RS", Nome = "Rio Grande do Sul"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("3180D6DD-6DD5-4562-B8F3-6785DA9F70FC"), UF = "RO", Nome = "Rondônia"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("D120E19C-210F-4A35-836C-E35D3DA068FB"), UF = "RR", Nome = "Roraima"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("1EA3ED66-26F8-413D-B401-FDAC5D2961F4"), UF = "SP", Nome = "São Paulo" });
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("3A54F9E3-DB6D-47CA-A897-AC59CD880C1F"), UF = "SC", Nome = "Santa Catarina"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("9F4372F7-EB03-4D2D-895B-7C64F058DECB"), UF = "SE", Nome = "Sergipe"});
            context.Estados.AddOrUpdate(new Estado() { EstadoId = new Guid("6FAB1DBD-1E5F-4F52-80AD-CB5BCC5F6B51"), UF = "TO", Nome = "Tocantins"});
        }
    }
}