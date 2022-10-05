using Domain.Contracts.Repositories;
using Domain.Contracts.UseCases;
using Domain.Entities;

namespace Application.UseCases.GetProduct
{
    public class GetProductUseCase : IGetProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public GetProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProduct(string code)
        {
            return _productRepository.GetProduct(code);
        }
    }
}
