using Application.Model;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class ConfigurationMapping : Profile
    {
        public ConfigurationMapping()
        {
            CreateMap<Produto, ProdutoModel>();
            CreateMap<ProdutoModel, Produto>();
        }

    }
}
