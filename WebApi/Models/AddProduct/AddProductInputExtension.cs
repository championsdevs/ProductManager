using Domain.Entities;

namespace WebApi.Models.AddProduct
{
    public static class AddProductInputExtension
    {
        public static Product ToProduct(this AddProductInput addProductInput)
        {
            return new Product(addProductInput.Name, addProductInput.Code);
        }
    }
}