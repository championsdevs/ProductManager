using Domain.Contracts.UseCases;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProductController : ControllerBase
    {
        private readonly IGetProductUseCase _getProductUseCase;

        public GetProductController(IGetProductUseCase getProductUseCase)
        {
            _getProductUseCase = getProductUseCase;
        }

        [HttpGet]
        public IActionResult Get(string code)
        {
            try
            {
                var product = _getProductUseCase.GetProduct(code);

                return Ok(product);
            }
            catch (ProductNotFoundException)
            {
                return NotFound();
            }
        }
    }
}