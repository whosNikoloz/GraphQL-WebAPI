using GraphQL.Types;
using GraphqlWebAPI.Models;

namespace GraphqlWebAPI.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Price);
        }
    }
}
