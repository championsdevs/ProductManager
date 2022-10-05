using Domain.Contracts.UseCases;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net;
using WebApi.Controllers;
using WebApi.Models.AddProduct;

namespace UnitTests.WebApi.Controllers
{
    public class AddProductControllerTest
    {
        [Fact]
        public void Given_Input_When_IsInvalid_Then_ShouldReturnBadRequest()
        {
            // Arrange
            var validator = new Mock<IValidator<AddProductInput>>();
            var addProductUseCase = new Mock<IAddProductUseCase>();
            var input = new AddProductInput();
            IList<ValidationFailure> failures = new List<ValidationFailure>
            {
                new ValidationFailure("any_property", "any_error_message")
            };

            validator.Setup(mock => mock.Validate(input))
                .Returns(new ValidationResult(failures));

            var sut = new AddProductController(validator.Object, addProductUseCase.Object);

            // Act
            var response = sut.Add(input) as ObjectResult;

            // Assert
            response!.StatusCode!.Value.Should().Be(HttpStatusCode.BadRequest.GetHashCode());
        }

        [Fact]
        public void Given_Input_When_IsValid_Then_ShouldAddProduct()
        {
            // Arrange


            // Act

            // Assert
        }
    }
}
