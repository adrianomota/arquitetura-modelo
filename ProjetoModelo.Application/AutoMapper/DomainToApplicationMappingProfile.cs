using AutoMapper;
using ProjetoModelo.Application.Validation;
using ProjetoModelo.Domain.ValueObjects;

namespace ProjetoModelo.Application.AutoMapper
{
    public class DomainToApplicationMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToApplicationMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ValidationError, ValidationAppError>();
            Mapper.CreateMap<ValidationResult, ValidationAppResult>();
        }
    }
}
