using InventoryManagement.Domain.Entities;
using MediatR;

namespace InventoryManagement.Application.Products.Queries;

public sealed record GetProductByIdQuery(Guid Id) : IRequest<Product?>;