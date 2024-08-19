using GraphqlWebAPI.Dto;
using GraphqlWebAPI.Models;
using GraphqlWebAPI.Services;

namespace GraphqlWebAPI.GraphQL
{
    public class Mutation
    {
        public string SayHello(string name) => $"Hello, {name}!";

        private readonly ProductService _productService;

        public Mutation(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<Product> CreateProductAsync(ProductDto input)
        {
            return await _productService.CreateProductAsync(input);
        }
    }
}
