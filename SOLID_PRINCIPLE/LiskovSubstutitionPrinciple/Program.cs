using Before = LiskovSubstutitionPrinciple.Before_Liskov;
using After = LiskovSubstutitionPrinciple.After_Liskov;

using System;
using System.Runtime.InteropServices;
using LiskovSubstutitionPrinciple.After_Liskov;

namespace LiskovSubstutitionPrinciple
{
    class Program
    {
        // Before using Liskov
        //static void Main(string[] args)
        //{
        //    Buyer linhPham = new Buyer
        //    {
        //        Name = "Linh Pham",
        //        Address = "HCM CITY",
        //        PhoneNumber = "1123243222"
        //    };
        //    Before.PropertyContract contract = new Before.CityContract(linhPham, "Contract of Linh Pham", DateTime.Now, DateTime.Now.AddDays(1));
        //    contract.PrintContractInfo();
        //    contract.CreateRentContract();
        //    Console.WriteLine("");
        //    contract.CreateBuyContract();
        //    Console.WriteLine("");

        //    Buyer linhPham2 = new Buyer
        //    {
        //        Name = "Linh Pham 2",
        //        Address = "AN GIANG",
        //        PhoneNumber = "32423423"
        //    };
        //    contract = new Before.RemoteAreaContract(linhPham2, "Contract of Linh Pham 2", DateTime.Now, DateTime.Now.AddDays(1));
        //    contract.PrintContractInfo();
        //    contract.CreateRentContract();
        //    Console.WriteLine("");
        //    contract.CreateBuyContract();
        //    Console.WriteLine("");

        //    Buyer foreigner = new Buyer
        //    {
        //        Name = "Donal Trump",
        //        Address = "Washington, United states",
        //        PhoneNumber = "2132324324"
        //    };
        //    contract = new Before.ForeignerContract(foreigner, "Contract of Donal Trump", DateTime.Now, DateTime.Now.AddDays(1));
        //    contract.PrintContractInfo();
        //    contract.CreateRentContract();
        //    Console.WriteLine("");
        //    contract.CreateBuyContract();
        //}

        // After using Liskov
        static void Main(string[] args)
        {
            Buyer linhPham = new Buyer
            {
                Name = "Linh Pham",
                Address = "HCM CITY",
                PhoneNumber = "1123243222"
            };

            After.PropertyContract contract = new After.CityContract(linhPham, "Contract of Linh Pham", DateTime.Now, DateTime.Now.AddDays(1));
            contract.PrintContractInfo();
            ((DomesticPropertyContract)contract).CreateRentContract();
            Console.WriteLine("");
            ((DomesticPropertyContract)contract).CreateBuyContract();
            Console.WriteLine("");

            Buyer linhPham2 = new Buyer
            {
                Name = "Linh Pham 2",
                Address = "AN GIANG",
                PhoneNumber = "32423423"
            };
            contract = new After.RemoteAreaContract(linhPham2, "Contract of Linh Pham 2", DateTime.Now, DateTime.Now.AddDays(1));
            contract.PrintContractInfo();
            ((DomesticPropertyContract)contract).CreateRentContract();
            Console.WriteLine("");
            ((DomesticPropertyContract)contract).CreateBuyContract();
            Console.WriteLine("");

            Buyer foreigner = new Buyer
            {
                Name = "Donal Trump",
                Address = "Washington, United states",
                PhoneNumber = "2132324324"
            };
            contract = new After.ForeignerContract(foreigner, "Contract of Donal Trump", DateTime.Now, DateTime.Now.AddDays(1));
            contract.PrintContractInfo();
            ((InternationalPropertyContract)contract).CreateRentContract();
        }
    }
}
