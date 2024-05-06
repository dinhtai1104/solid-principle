using System.Collections.Generic;
using System.Linq;

namespace OpenClosedPrinciple.Before_Open_Closed
{
    public class FileFilter
    {
        public IEnumerable<FileItem> FilterByType(IEnumerable<FileItem> fileItems, FileType fileType)
        {
            foreach(var item in fileItems)
            {
                if (item.FileType == fileType)
                    yield return item;
            }
        }

        public IEnumerable<FileItem> FilterByName(IEnumerable<FileItem> fileItems, string fileName)
        {
            foreach (var item in fileItems)
            {
                if (item.FileName == fileName)
                    yield return item;
            }
        }

        public IEnumerable<FileItem> FilterBySizeRange(IEnumerable<FileItem> fileItems, 
            int min = 100, int max = 200)
        {
            return fileItems.Where(c => c.FileSize >= min && c.FileSize <= max);
        }
    }
}
