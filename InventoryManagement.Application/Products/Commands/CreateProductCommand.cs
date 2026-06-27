using MediatR;

namespace InventoryManagement.Application.Products.Commands;



public sealed record CreateProductCommand(string Name, string Description, decimal Price, int Quantity, int LowStockThreshold) : IRequest<Guid>;        // When this command succeed i request a Guid

// namespace InventoryManagement.Application.Products.Commands;

// public sealed record CreateProductCommand(
//     string Name,
//     string Description,
//     decimal Price,
//     int Quantity,
//     int LowStockThreshold
// );