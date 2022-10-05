using Domain.Entities;

namespace Domain.Contracts.UseCases
{
    public interface IGetProductUseCase
    {
        Product? GetProduct(string code);
    }
}
