using MediatR;

namespace InventoryManagement.Application.Products.Commands;

public sealed record UpdateProductCommand(Guid Id, string Name, string Description, decimal Price, int Quantity, int LowStockThreshold) : IRequest;
