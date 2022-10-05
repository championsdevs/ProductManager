using Domain.Entities;

namespace Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(string code);
    }
}