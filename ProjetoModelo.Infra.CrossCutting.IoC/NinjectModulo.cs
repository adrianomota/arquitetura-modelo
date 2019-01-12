using Ninject.Modules;
using ProjetoModelo.Application;
using ProjetoModelo.Application.Interfaces;
using ProjetoModelo.Domain.Interfaces.Repository;
using ProjetoModelo.Domain.Interfaces.Repository.ADO;
using ProjetoModelo.Domain.Interfaces.Repository.ReadOnly;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.Services;
using ProjetoModelo.Infra.Data.Context;
using ProjetoModelo.Infra.Data.Interfaces;
using ProjetoModelo.Infra.Data.Repositories;
using ProjetoModelo.Infra.Data.Repositories.ADO;
using ProjetoModelo.Infra.Data.Repositories.ReadOnly;
using ProjetoModelo.Infra.Data.UoW;

namespace ProjetoModelo.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // app
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();
            Bind<IEnderecoAppService>().To<EnderecoAppService>();
            Bind<IEstadoAppService>().To<EstadoAppService>();
            Bind<ICidadeAppService>().To<CidadeAppService>();
            Bind<IFornecedorAppService>().To<FornecedorAppService>();
            Bind<IVendaAppService>().To<VendaAppService>();

            // service
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IEnderecoService>().To<EnderecoService>();
            Bind<IEstadoService>().To<EstadoService>();
            Bind<ICidadeService>().To<CidadeService>();
            Bind<IFornecedorService>().To<FornecedorService>();
            Bind<IVendaService>().To<VendaService>();

            // data repos
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();
            Bind<IEstadoRepository>().To<EstadoRepository>();
            Bind<ICidadeRepository>().To<CidadeRepository>();
            Bind<IFornecedorRepository>().To<FornecedorRepository>();
            Bind<IVendaRepository>().To<VendaRepository>();
      
            // data repos read only
            Bind<IClienteReadOnlyRepository>().To<ClienteReadOnlyRepository>();
            Bind<IFornecedorReadOnlyRepository>().To<FornecedorReadOnlyRepository>();
            Bind<IVendaReadOnlyRepository>().To<VendaReadOnlyRepository>();
            Bind<IProdutoReadOnlyRepository>().To<ProdutoReadOnlyRepository>();

            // ado repos only
            Bind<IClienteADORepository>().To<ClienteADORepository>();

            // data configs
            Bind(typeof(IContextManager<>)).To(typeof(ContextManager<>));
            Bind<IDbContext>().To<ProjetoModeloContext>();
            Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>));

        }
    }
}
