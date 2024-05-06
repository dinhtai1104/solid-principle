using OpenClosedPrinciple.After_Open_Closed.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.After_Open_Closed.FilterCriterias
{
    class ProductNameCriteriaFilter : ICriteriaFilter<ProductItem>
    {
        string _name;
        public ProductNameCriteriaFilter(string name)
        {
            _name = name;
        }
        public bool IsMatchCriteria(ProductItem targetItem)
        {
            return targetItem.Name == _name;
        }
    }
}
