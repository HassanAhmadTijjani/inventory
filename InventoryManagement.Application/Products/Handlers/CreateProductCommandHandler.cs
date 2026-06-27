using MediatR;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Application.Common.Interfaces;
using InventoryManagement.Application.Products.Commands;

namespace InventoryManagement.Application.Products.Handlers;

public class CreateProductCommandHandler(
    IProductRepository productRepository) : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task<Guid> Handle(
        CreateProductCommand request,
        CancellationToken cancellationToken)
    {
        
        var product = new Product(
            request.Name,
            request.Description,
            request.Price,
            request.Quantity,
            request.LowStockThreshold);

        await _productRepository.AddAsync(product);

        await _productRepository.SaveChangesAsync();

        return product.Id;
    }
}