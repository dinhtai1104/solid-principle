using DependencyInversionPrinciple.AfterDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.AfterDI.Notifications
{
    class NotificationFactory
    {
        public static List<IMessenger<NotificationItem>> CreateMessengers()
        {
            var messengers = new List<IMessenger<NotificationItem>>
            {
                new EmailNotification(),
                new SmsNotification(),
                new PushNotification()
            };
            return messengers;
        }
    }
}
