using InventoryManagement.Application.Common.Interfaces;
using InventoryManagement.Application.Products.Commands;
using InventoryManagement.Domain.Entities;
using MediatR;

namespace InventoryManagement.Application.Products.Handlers;
public class UpdateProductCommandHandler(IProductRepository productRepository) : IRequestHandler<UpdateProductCommand>
{
    private readonly IProductRepository _productRepository = productRepository;
    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.Id) ?? throw new Exception("Product not found");
        product.Update(request.Name, request.Description, request.Price, request.Quantity, request.LowStockThreshold);
        _productRepository.Update(product);
        await _productRepository.SaveChangesAsync();
    }

}