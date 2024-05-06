using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.AfterISP
{
    interface ILeaderActivity : IDevActivity
    {
        void ReviewCode();
    }
}
