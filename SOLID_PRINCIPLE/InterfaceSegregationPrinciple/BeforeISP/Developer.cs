using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.BeforeISP
{
    class Developer : IDevActivity
    {
        public string Name { get; set; }

        public void JoinMeeting()
        {
            Console.WriteLine("I join the meeting...!");
        }

        public void ReviewCode()
        {
            throw new Exception("No, Only Team Leader can review code");
        }

        public void StudyRequirement()
        {
            Console.WriteLine("FUCK, It is a stupid document from BA.");
        }

        public void WriteCode()
        {
            Console.WriteLine("OH YEAH, I AM SUPPER CODER");
        }
    }
}
