using InventoryManagement.Application.Common.Interfaces;
using InventoryManagement.Application.Products.Queries;
using InventoryManagement.Domain.Entities;
using MediatR;

namespace InventoryManagement.Application.Products.Handlers;

public class GetProductByIdQueryHandler(IProductRepository productRepository) : IRequestHandler<GetProductByIdQuery, Product?>
{
    private readonly IProductRepository _productRepository = productRepository;
    public async Task<Product?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken){
        return await _productRepository.GetByIdAsync(request.Id);
    }
}
