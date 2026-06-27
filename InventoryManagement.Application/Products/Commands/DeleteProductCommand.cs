using MediatR;
namespace InventoryManagement.Application.Products.Commands;

public sealed record DeleteProductCommand(Guid Id) : IRequest;