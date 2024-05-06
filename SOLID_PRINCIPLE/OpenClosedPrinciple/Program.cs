using System;
using System.Collections.Generic;
using System.Linq;
using Before = OpenClosedPrinciple.Before_Open_Closed;
using After = OpenClosedPrinciple.After_Open_Closed;

namespace OpenClosedPrinciple
{
    class Program
    {
        // Before applying Open-Closed Principle
        //static void Main(string[] args)
        //{
        //    var fileItems = CreateData();

        //    Before.FileFilter fileFilter = new Before.FileFilter();

        //    var imageFiles = fileFilter.FilterByType(fileItems, FileType.Image);
        //    Console.WriteLine("Image Files: {0}", string.Join(", ", imageFiles.Select(c => c.FileName)));

        //    var latestFiles = fileFilter.FilterByName(fileItems, "File_3");
        //    Console.WriteLine("Latest Files: {0}", string.Join(", ", latestFiles.Select(c => c.FileName)));

        //    var sizeFiles = fileFilter.FilterBySizeRange(fileItems, 100, 4000);
        //    Console.WriteLine("Meet Size Files: {0}", string.Join(", ", sizeFiles.Select(c => c.FileName)));
        //}

        // After applying Open-Closed Principle
        static void Main(string[] args)
        {
            var fileItems = CreateData();

            After.FileFilter fileFilter = new After.FileFilter();

            var results = fileFilter.Filter(fileItems, new After.FilterCriterias.ImageFileCriteriaFilter());
            Console.WriteLine("Image Files: {0}", string.Join(", ", results.Select(c => c.FileName)));

            results = fileFilter.Filter(fileItems, new After.FilterCriterias.FileNameCriteriaFilter("File_3"));
            Console.WriteLine("Image Files: {0}", string.Join(", ", results.Select(c => c.FileName)));

            results = fileFilter.Filter(fileItems, new After.FilterCriterias.FileSizeRangeCriteriaFilter(100, 4000));
            Console.WriteLine("Meet Size Files: {0}", string.Join(", ", results.Select(c => c.FileName)));
        }

        private static IEnumerable<FileItem> CreateData()
        {
            return new List<FileItem>
            {
                new FileItem
                {
                    FileName = "File_1",
                    FileSize = new Random().Next(100, 10000),
                    FileType = FileType.Text,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },

                new FileItem
                {
                    FileName = "File_2",
                    FileSize = new Random().Next(100, 10000),
                    FileType = FileType.Image,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },

                new FileItem
                {
                    FileName = "File_3",
                    FileSize = new Random().Next(100, 10000),
                    FileType = FileType.Exe,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            };
        }
    }
}
