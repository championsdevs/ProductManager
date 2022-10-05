using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string code)
        {
            return Ok(new Product("", code));
        }
    }
}
