using Microsoft.EntityFrameworkCore;
using SpecificationPattern.Specifications.Interfaces;

namespace SpecificationPattern.Specifications.Evaluators
{
    public static class SpecificationEvaluator<T> where T : class
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            var query = inputQuery;

            // اعمال Criteria
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            // اعمال Includes
            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }

}
