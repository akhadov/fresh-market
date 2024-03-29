﻿using Application.Catalog.Commands.CreateCategory;
using AutoMapper;
using Contracts.Catalogs;
using Domain.Entities.Catalog;

namespace Application.Catalog.Mappers;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, CategoryResponse>().ReverseMap();
        CreateMap<Category, CreateCategoryCommand>().ReverseMap();
    }
}