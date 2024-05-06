using OpenClosedPrinciple.After_Open_Closed.Interfaces;

namespace OpenClosedPrinciple.After_Open_Closed.FilterCriterias
{
    public class ImageFileCriteriaFilter : ICriteriaFilter<FileItem>
    {
        public bool IsMatchCriteria(FileItem targetItem)
        {
            return targetItem.FileType == FileType.Image;
        }
    }
}
