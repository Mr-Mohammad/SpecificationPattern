using System.Linq.Expressions;
using SpecificationPattern.Models;
using SpecificationPattern.Specifications.Base;

namespace SpecificationPattern.Specifications.Products
{
    public class ProductByCategorySpecification : BaseSpecification<Category>
    {
        public ProductByCategorySpecification(int id)
          : base(x => x.Id >= id)
        {
        }
    }
}
