using OpenClosedPrinciple.After_Open_Closed.Interfaces;
using System.Collections.Generic;

namespace OpenClosedPrinciple.After_Open_Closed
{
    public class FileFilter : IFilter<FileItem>
    {
        public IEnumerable<FileItem> Filter(IEnumerable<FileItem> source, ICriteriaFilter<FileItem> criteriaFilter)
        {
            foreach (var item in source)
            {
                if (criteriaFilter.IsMatchCriteria(item))
                    yield return item;
            }
        }
    }
}
