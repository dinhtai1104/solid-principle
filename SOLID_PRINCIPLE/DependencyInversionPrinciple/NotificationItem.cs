using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    class NotificationItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime SentDate { get; set; }
        public NotificationType NotificationType { get; set; }
    }

    enum NotificationType
    {
        EMAIL,
        SMS,
        PUSH
    }
}
