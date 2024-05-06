using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.BeforeDI.Notifications
{
    class EmailNotification
    {
        public void Send(NotificationItem notificationItem)
        {
            Console.WriteLine("Email Notification");
            Console.WriteLine($"\t\tId: {notificationItem.Id}");
            Console.WriteLine($"\t\tTitle: {notificationItem.Title}");
            Console.WriteLine($"\t\tSent Date: {notificationItem.SentDate}");
            Console.WriteLine($"\t\tContent: {notificationItem.Content}");
            Console.WriteLine(" ");
        }
    }
}
