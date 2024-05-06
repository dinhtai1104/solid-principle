using OpenClosedPrinciple.After_Open_Closed.Interfaces;

namespace OpenClosedPrinciple.After_Open_Closed.FilterCriterias
{
    public class FileNameCriteriaFilter : ICriteriaFilter<FileItem>
    {
        string _name;
        public FileNameCriteriaFilter(string name)
        {
            _name = name;
        }
        public bool IsMatchCriteria(FileItem targetItem)
        {
            return targetItem.FileName == _name;
        }
    }
}
