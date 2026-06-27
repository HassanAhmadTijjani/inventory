using InventoryManagement.Application.Common.Interfaces;
using InventoryManagement.Application.Products.Commands;
using MediatR;

namespace InventoryManagement.Application.Products.Handlers;

public class DeleteProductCommandHandler(IProductRepository productRepository)
    : IRequestHandler<DeleteProductCommand>
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task Handle(
        DeleteProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.Id) ?? throw new Exception("Product not found.");
        _productRepository.Delete(product);

        await _productRepository.SaveChangesAsync();
    }
}