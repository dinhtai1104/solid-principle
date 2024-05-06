using DependencyInversionPrinciple.AfterDI.Interfaces;
using DependencyInversionPrinciple.AfterDI.Notifications.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.AfterDI.Notifications
{
    class EmailNotification : IMessenger<NotificationItem>
    {
        public List<NotificationItem> MessageItems { get; }

        public EmailNotification()
        {
            MessageItems = new List<NotificationItem>();
        }

        public void Send()
        {
            MessageItems.ForEach(x =>
            {
                var item = x as EmailNotificationItem;
                Console.WriteLine("Email Notification");
                Console.WriteLine($"\t\tId: {item.Id}");
                Console.WriteLine($"\t\tTitle: {item.Title}");
                Console.WriteLine($"\t\tSent Date: {item.SentDate}");
                Console.WriteLine($"\t\tContent: {item.Content}");
            });
            Console.WriteLine(" ");
        }

        public void AddMessage(NotificationItem message)
        {
            if (message.GetType() != typeof(EmailNotificationItem))
                return;

            MessageItems.Add(message);
        }
    }
}
