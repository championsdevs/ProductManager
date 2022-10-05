using Domain.Contracts.Repositories;
using Domain.Entities;
using Domain.Exceptions;

namespace Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IList<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public Product GetProduct(string code)
        {
            var product = _products.FirstOrDefault(x => x.Code == code);

            if (product == null)
            {
                throw new ProductNotFoundException("The product cannot be found");
            }

            return product;
        }
    }
}