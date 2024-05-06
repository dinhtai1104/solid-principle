using System;

namespace OpenClosedPrinciple
{
    public class FileItem
    {
        public string FileName { get; set; }
        public FileType FileType { get; set; }
        public int FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
