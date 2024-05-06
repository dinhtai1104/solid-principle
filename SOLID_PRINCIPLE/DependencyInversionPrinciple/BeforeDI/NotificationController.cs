using DependencyInversionPrinciple.BeforeDI.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.BeforeDI
{
    class NotificationController
    {
        private EmailNotification _emailNotification;
        private SmsNotification _smsNotification;
        private PushNotification _pushNotification;

        public NotificationController()
        {
            _emailNotification = new EmailNotification();
            _smsNotification = new SmsNotification();
            _pushNotification = new PushNotification();
        }

        public void SendEmailNotification(NotificationItem notificationItem)
        {
            _emailNotification.Send(notificationItem);
        }

        public void SendSmsNotification(NotificationItem notificationItem)
        {
            _smsNotification.Send(notificationItem);
        }

        public void SendPushNotification(NotificationItem notificationItem)
        {
            _pushNotification.Send(notificationItem);
        }
    }
}
