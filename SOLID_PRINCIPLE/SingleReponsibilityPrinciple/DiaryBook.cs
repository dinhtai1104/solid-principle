using SingleResponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleReponsibilityPrinciple
{
    class DiaryBook
    {
        private List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

        public List<DiaryEntry> GetDiaryBook()
        {
            return diaryEntries;
        }
    }
}
