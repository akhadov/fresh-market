using Application.Catalog.Mappers;
using Application.Common.Exceptions;
using Application.Common.Interfaces.Messaging;
using Application.Common.Interfaces.Persistence;
using AutoMapper;
using Contracts.Catalogs;
using Domain.Entities.Catalog;

namespace Application.Catalog.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, ProductResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }


    public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var productRequest = _mapper.Map<Product>(request);

        if (productRequest is null)
        {
            throw new BadRequestException("There is an issue with mapping while creating new product");
        }

        await _productRepository.CreateAsync(productRequest);

        return productResponse;

    }
}