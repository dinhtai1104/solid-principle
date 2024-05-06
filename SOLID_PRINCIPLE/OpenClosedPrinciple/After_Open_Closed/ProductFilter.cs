using OpenClosedPrinciple.After_Open_Closed.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.After_Open_Closed
{
    class ProductFilter : IFilter<ProductItem>
    {
        public IEnumerable<ProductItem> Filter(IEnumerable<ProductItem> source, ICriteriaFilter<ProductItem> criteriaFilter)
        {
            foreach (var item in source)
            {
                if (criteriaFilter.IsMatchCriteria(item))
                    yield return item;
            }
        }
    }
}
