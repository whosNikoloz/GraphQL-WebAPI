using GraphqlWebAPI.Models;
using GraphqlWebAPI.Services;

namespace GraphqlWebAPI.GraphQL
{
    public class Query
    {
        public string Hello() => "Hello, GraphQL!";
        private readonly ProductService _productService;

        public Query(ProductService productService)
        {
            _productService = productService;
        }


        public IQueryable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productService.GetProductByIdAsync(id);
        }
    }
}
