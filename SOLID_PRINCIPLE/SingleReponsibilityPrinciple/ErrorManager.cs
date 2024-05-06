using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    class ErrorManager
    {
        public void LogError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}, Stack Trace: {ex.StackTrace}");
        }
    }
}
