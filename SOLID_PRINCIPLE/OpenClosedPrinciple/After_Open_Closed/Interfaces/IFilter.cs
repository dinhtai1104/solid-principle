using System.Collections.Generic;

namespace OpenClosedPrinciple.After_Open_Closed.Interfaces
{
    public interface IFilter<T> where T: class
    {
        IEnumerable<T> Filter(IEnumerable<T> source, ICriteriaFilter<T> item);
    }
}
