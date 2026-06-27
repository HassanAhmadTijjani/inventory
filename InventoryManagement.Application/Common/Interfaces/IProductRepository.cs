using InventoryManagement.Domain.Entities;

namespace InventoryManagement.Application.Common.Interfaces;

public interface IProductRepository
{
    Task AddAsync(Product product);

    Task<Product?> GetByIdAsync(Guid id);

    Task<IEnumerable<Product>> GetAllAsync();

    void Update(Product product);

    void Delete(Product product);

    Task SaveChangesAsync();
}