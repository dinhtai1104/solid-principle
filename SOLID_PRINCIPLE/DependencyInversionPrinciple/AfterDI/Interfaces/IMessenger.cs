using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.AfterDI.Interfaces
{
    interface IMessenger<T>
    {
        List<T> MessageItems { get; }
        void Send();
        void AddMessage(T message);
    }
}
