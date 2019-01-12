using AutoMapper;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Endereco>();

            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<EstadoViewModel, Estado>();
            Mapper.CreateMap<CidadeViewModel, Cidade>();

            Mapper.CreateMap<VendaViewModel, Venda>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<TipoVendaViewEnum, TipoVenda>();
        }
    }
}