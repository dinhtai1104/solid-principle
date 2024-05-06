using SingleReponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class ExportDiary
    {
        ErrorManager _errorManager = new ErrorManager();

        public void SaveToText(string fileName, List<DiaryEntry> diaryEntries)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(fileName))
                {
                    foreach (var s in diaryEntries)
                    {
                        tw.WriteLine($"Date: {s.CreatedDate:dd/MM/yyyy}");
                        tw.WriteLine($"Title: {s.Title}");
                        tw.WriteLine($"Content: {s.Content}");

                        if (diaryEntries.IndexOf(s) != diaryEntries.Count - 1)
                        {
                            tw.WriteLine(Environment.NewLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _errorManager.LogError(ex);
            }
        }

        public void PushToCloud()
        {
            // Do something...
        }
    }
}
