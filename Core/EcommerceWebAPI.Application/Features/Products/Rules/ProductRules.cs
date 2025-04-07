using EcommerceWebAPI.Application.Bases;
using EcommerceWebAPI.Application.Features.Products.Exceptions;
using EcommerceWebAPI.Domain.Entities;

namespace EcommerceWebAPI.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x => x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
