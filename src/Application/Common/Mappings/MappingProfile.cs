using Application.DTOs;
using AutoMapper;
using Domain.Entities.Catalog;

namespace Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
    }
}
