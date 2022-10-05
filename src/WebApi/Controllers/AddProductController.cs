using Domain.Contracts.UseCases;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.AddProduct;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddProductController : ControllerBase
    {
        private readonly IValidator<AddProductInput> _validator;
        private readonly IAddProductUseCase _addProductUseCase;

        public AddProductController(IValidator<AddProductInput> validator, IAddProductUseCase addProductUseCase)
        {
            _validator = validator;
            _addProductUseCase = addProductUseCase;
        }

        [HttpPost]
        public IActionResult Add(AddProductInput input)
        {
            var validationResult = _validator.Validate(input);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            _addProductUseCase.AddProduct(input.ToProduct());

            var url = this.Url.Action("Get", "GetProduct",
                new { code = input.Code }, this.Request.Scheme);

            return Created(url!, input);
        }
    }
}