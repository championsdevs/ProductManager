using Domain.Contracts.Repositories;
using Domain.Contracts.UseCases;
using Domain.Entities;

namespace Application.UseCases.AddProduct
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository _addProductRepository;

        public AddProductUseCase(IProductRepository addProductRepository)
        {
            _addProductRepository = addProductRepository;
        }

        public void AddProduct(Product product)
        {
            _addProductRepository.AddProduct(product);
        }
    }
}