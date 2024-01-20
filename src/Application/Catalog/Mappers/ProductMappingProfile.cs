using Application.Catalog.Commands.CreateProduct;
using AutoMapper;
using Contracts.Catalogs;
using Domain.Entities.Catalog;

namespace Application.Catalog.Mappers;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<Product, ProductResponse>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
    }
}