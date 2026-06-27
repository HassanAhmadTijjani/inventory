using InventoryManagement.Application.Common.Interfaces;
using InventoryManagement.Application.Products.Queries;
using InventoryManagement.Domain.Entities;
using MediatR;
namespace InventoryManagement.Application.Products.Handlers;
public class GetProductsQueryHandler(IProductRepository productRepository) : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly IProductRepository _productRepository = productRepository;
    public async Task<IEnumerable<Product>> Handle(
       GetProductsQuery request,
       CancellationToken cancellationToken)
    {
        return await _productRepository.GetAllAsync();
    }
}