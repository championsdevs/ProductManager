using Domain.Contracts.Repositories;
using Domain.Entities;

namespace Infra.Repository
{
    public class AddProductRepository : IAddProductRepository
    {
        private readonly IList<Product> _products;

        public AddProductRepository()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}