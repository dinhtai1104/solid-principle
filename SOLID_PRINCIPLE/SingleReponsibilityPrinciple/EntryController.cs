using SingleReponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class EntryController
    {
        private ErrorManager _errorManager = new ErrorManager();

        public void AddDiary(DiaryEntry diaryEntry, List<DiaryEntry> diaryEntries)
        {
            try
            {
                diaryEntries.Add(diaryEntry);
            }
            catch (Exception ex)
            {
                _errorManager.LogError(ex);
            }
        }

        public void RemoveDiary(DiaryEntry diaryEntry, List<DiaryEntry> diaryEntries)
        {
            try
            {
                diaryEntries.Remove(diaryEntry);
            }
            catch (Exception ex)
            {
                _errorManager.LogError(ex);
            }
        }
    }
}
