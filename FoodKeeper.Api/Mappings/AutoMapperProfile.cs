using AutoMapper;
using FoodKeeper.Api.Dtos;
using FoodKeeper.Api.Models;

namespace FoodKeeper.Api.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Categoria, CategoriaDto>();
            CreateMap<CreateCategoriaDto, Categoria>();

        }
    }
}
