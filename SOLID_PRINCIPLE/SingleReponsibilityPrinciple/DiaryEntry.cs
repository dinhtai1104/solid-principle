using System;
using System.Collections.Generic;
using System.Text;

namespace SingleReponsibilityPrinciple
{
    class DiaryEntry
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
    }
}
