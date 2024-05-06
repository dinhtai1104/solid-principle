using DependencyInversionPrinciple.AfterDI.Interfaces;
using DependencyInversionPrinciple.AfterDI.Notifications.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.AfterDI.Notifications
{
    class PushNotification : IMessenger<NotificationItem>
    {
        public List<NotificationItem> MessageItems { get; }

        public PushNotification()
        {
            MessageItems = new List<NotificationItem>();
        }

        public void Send()
        {
            MessageItems.ForEach(x =>
            {
                var item = x as PushNotificationItem;
                Console.WriteLine("Push Notification");
                Console.WriteLine($"\t\tId: {item.Id}");
                Console.WriteLine($"\t\tTitle: {item.Title}");
                Console.WriteLine($"\t\tSent Date: {item.SentDate}");
                Console.WriteLine($"\t\tContent: {item.Content}");
            });
            Console.WriteLine(" ");
        }

        public void AddMessage(NotificationItem message)
        {
            if (message.GetType() != typeof(PushNotificationItem))
                return;

            MessageItems.Add(message);
        }
    }
}
