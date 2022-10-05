using Domain.Entities;

namespace Domain.Contracts.Repositories
{
    public interface IAddProductRepository
    {
        void AddProduct(Product product);
    }
}