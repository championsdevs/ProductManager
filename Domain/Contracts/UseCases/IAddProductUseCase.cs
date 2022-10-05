using Domain.Entities;

namespace Domain.Contracts.UseCases
{
    public interface IAddProductUseCase
    {
        void AddProduct(Product product);
    }
}