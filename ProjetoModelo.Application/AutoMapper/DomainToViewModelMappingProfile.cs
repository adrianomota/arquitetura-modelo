using AutoMapper;
using ProjetoModelo.Application.ViewModels;
using ProjetoModelo.Domain.Entities;

namespace ProjetoModelo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dest => dest.Enderecos, opt => opt.MapFrom(src => src.EnderecoList));

            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();

            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
            Mapper.CreateMap<Estado, EstadoViewModel>();
            Mapper.CreateMap<Cidade, CidadeViewModel>();

            Mapper.CreateMap<Venda, VendaViewModel>();
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();
            Mapper.CreateMap<TipoVenda, TipoVendaViewEnum>();

        }
    }
}