using SingleResponsibilityPrinciple;
using System;

namespace SingleReponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            DiaryBook diaryBook = new DiaryBook();

            var allEntries = diaryBook.GetDiaryBook();

            EntryController entryController = new EntryController();

            entryController.AddDiary(new DiaryEntry
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now.AddDays(-1),
                Title = "Today is the shit day",
                Content = "I made a lot of bugs in project so sad."
            }, allEntries);

            entryController.AddDiary(new DiaryEntry
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Title = "I crushed a lady",
                Content = "I crushed a lady and she is a tester who found bugs for me every day so fun haha."
            }, allEntries);



            foreach(var s in allEntries)
            {
                Console.WriteLine($"Date: {s.CreatedDate:dd/MM/yyyy}");
                Console.WriteLine($"Title: {s.Title}");
                Console.WriteLine($"Content: {s.Content}");

                if (allEntries.IndexOf(s) != allEntries.Count - 1)
                {
                    Console.WriteLine();
                }
            }

            ExportDiary export = new ExportDiary();

            var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            export.SaveToText("myDiary_"+ Timestamp + ".txt", allEntries);
        }
    }
}
