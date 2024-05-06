using System;
using Before = InterfaceSegregationPrinciple.BeforeISP;
using After = InterfaceSegregationPrinciple.AfterISP;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        // Before applying ISP
        //static void Main(string[] args)
        //{
        //    BeforeISP.IDevActivity dev = new BeforeISP.Developer();
        //    Console.WriteLine("Activity for developer");
        //    dev.StudyRequirement();
        //    dev.JoinMeeting();
        //    dev.WriteCode();
        //    dev.ReviewCode();

        //    Console.WriteLine(" ");

        //    Console.WriteLine("Activity for Team leader");
        //    dev = new BeforeISP.TeamLeader();
        //    dev.StudyRequirement();
        //    dev.JoinMeeting();
        //    dev.WriteCode();
        //    dev.ReviewCode();
        //}

        // After applying ISP
        static void Main(string[] args)
        {
            After.IDevActivity dev = new After.Developer();
            Console.WriteLine("Activity for developer");
            dev.StudyRequirement();
            dev.JoinMeeting();
            dev.WriteCode();

            Console.WriteLine(" ");

            Console.WriteLine("Activity for Team leader");
            After.ILeaderActivity leader = new After.TeamLeader();
            leader.StudyRequirement();
            leader.JoinMeeting();
            leader.WriteCode();
            leader.ReviewCode();
        }
    }
}
