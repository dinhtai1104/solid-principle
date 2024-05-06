using DependencyInversionPrinciple.AfterDI.Interfaces;
using DependencyInversionPrinciple.AfterDI.Notifications;
using DependencyInversionPrinciple.AfterDI.Notifications.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.AfterDI
{
    class NotificationController
    {
        private List<IMessenger<NotificationItem>> _notificationMessengers;

        public NotificationController() 
        {
            _notificationMessengers = NotificationFactory.CreateMessengers();
        }

        public NotificationController(List<IMessenger<NotificationItem>> messengers)
        {
            _notificationMessengers = messengers;
        }

        public void AddToQueue(List<NotificationItem> messageitems)
        {
            foreach(var message in messageitems)
            {
                foreach (var messenger in _notificationMessengers)
                {
                    messenger.AddMessage(message);
                }
            }         
        }

        public void Send()
        {
            foreach (var messenger in _notificationMessengers)
            {
                messenger.Send();
            }
        }
    }
}
