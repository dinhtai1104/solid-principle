using System;
using System.Collections.Generic;
using System.Text;

namespace SingleReponsibilityPrinciple
{
    class ClassA
    {

    }
    class ClassB
    {

    }

    class Sample // High Level
    {
        ClassA a = new ClassA(); // Low level
        ClassB b = new ClassB(); //Low level

        public Sample()
        {

        }
    }
}
