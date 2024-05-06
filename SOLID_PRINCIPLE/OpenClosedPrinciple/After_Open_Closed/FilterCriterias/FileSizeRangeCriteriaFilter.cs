using OpenClosedPrinciple.After_Open_Closed.Interfaces;

namespace OpenClosedPrinciple.After_Open_Closed.FilterCriterias
{
    public class FileSizeRangeCriteriaFilter : ICriteriaFilter<FileItem>
    {
        int _min;
        int _max;
        public FileSizeRangeCriteriaFilter(int min, int max)
        {
            _min = min;
            _max = max;
        }
        public bool IsMatchCriteria(FileItem targetItem)
        {
            return targetItem.FileSize >= _min && targetItem.FileSize <= _max;
        }
    }
}
