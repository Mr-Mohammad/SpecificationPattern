using SpecificationPattern.Models;
using SpecificationPattern.Specifications.Base;

namespace SpecificationPattern.Specifications.Products
{
    public class ProductByPriceSpecification : BaseSpecification<Product>
    {
        public ProductByPriceSpecification(decimal minPrice, decimal maxPrice)
            : base(x => x.Price >= minPrice && x.Price <= maxPrice)
        {
            AddInclude(x => x.category); // اضافه کردن Navigation Property
        }
    }
}
