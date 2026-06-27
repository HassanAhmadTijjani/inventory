using InventoryManagement.Domain.Entities;
using MediatR;

namespace InventoryManagement.Application.Products.Queries;
public class GetProductsQuery : IRequest<IEnumerable<Product>>;