using DependencyInversionPrinciple.BeforeDI;
using System;
using System.Collections.Generic;
using Before = DependencyInversionPrinciple.BeforeDI;
using After = DependencyInversionPrinciple.AfterDI;
using DependencyInversionPrinciple.AfterDI.Notifications.Items;
using DependencyInversionPrinciple.AfterDI.Notifications;

namespace DependencyInversionPrinciple
{
    #region [Before DI]
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Before.NotificationController notificationController = new NotificationController();
    //        var notificationItems = CreateDemoData();

    //        foreach (var item in notificationItems)
    //        {
    //            switch (item.NotificationType)
    //            {
    //                case NotificationType.EMAIL:
    //                    notificationController.SendEmailNotification(item);
    //                    break;
    //                case NotificationType.PUSH:
    //                    notificationController.SendPushNotification(item);
    //                    break;
    //                case NotificationType.SMS:
    //                    notificationController.SendSmsNotification(item);
    //                    break;
    //                default:
    //                    throw new NotSupportedException();
    //            }
    //        }
    //    }

    //    static List<NotificationItem> CreateDemoData()
    //    {
    //        return new List<NotificationItem>
    //        {
    //            new NotificationItem
    //            {
    //                Id = Guid.NewGuid(),
    //                Title = "This is title notification for SMS",
    //                Content = "I love you",
    //                CreatedDate = DateTime.Now.AddDays(-1),
    //                SentDate = DateTime.Now,
    //                NotificationType = NotificationType.SMS
    //            },
    //            new NotificationItem
    //            {
    //                Id = Guid.NewGuid(),
    //                Title = "This is title notification for Email",
    //                Content = "I love you",
    //                CreatedDate = DateTime.Now.AddDays(-1),
    //                SentDate = DateTime.Now,
    //                NotificationType = NotificationType.EMAIL
    //            },
    //            new NotificationItem
    //            {
    //                Id = Guid.NewGuid(),
    //                Title = "This is title notification for Push",
    //                Content = "I love you",
    //                CreatedDate = DateTime.Now.AddDays(-1),
    //                SentDate = DateTime.Now,
    //                NotificationType = NotificationType.PUSH
    //            }
    //        };
    //    }
    //}
    #endregion [Before DI]

    #region [After DI]
    class Program
    {
        static void Main(string[] args)
        {
            //After.NotificationController notificationController = new After.NotificationController()
            After.NotificationController notificationController = 
                new After.NotificationController(NotificationFactory.CreateMessengers());
            var notificationItems = CreateDemoData();
            notificationController.AddToQueue(notificationItems);
            notificationController.Send();
        }

        static List<NotificationItem> CreateDemoData()
        {
            return new List<NotificationItem>
            {
                new After.Notifications.Items.SmsNotificationItem
                {
                    Id = Guid.NewGuid(),
                    Title = "This is title notification for SMS",
                    Content = "I love you",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    SentDate = DateTime.Now,
                    NotificationType = NotificationType.SMS
                },
                new After.Notifications.Items.EmailNotificationItem
                {
                    Id = Guid.NewGuid(),
                    Title = "This is title notification for Email",
                    Content = "I love you",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    SentDate = DateTime.Now,
                    NotificationType = NotificationType.EMAIL
                },
                new After.Notifications.Items.PushNotificationItem
                {
                    Id = Guid.NewGuid(),
                    Title = "This is title notification for Push",
                    Content = "I love you",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    SentDate = DateTime.Now,
                    NotificationType = NotificationType.PUSH
                }
            };
        }
    }
    #endregion [After DI]
}
