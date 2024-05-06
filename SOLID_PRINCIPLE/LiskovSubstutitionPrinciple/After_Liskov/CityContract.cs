using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstutitionPrinciple.After_Liskov
{
    class CityContract: DomesticPropertyContract
    {
        public CityContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate): 
            base(buyer, contractName, createdDate, validDate) { }

        public override void CreateBuyContract()
        {
            base.CreateBuyContract();
            Console.WriteLine("Tax for City People is 15% / contract");
        }

        public override void CreateRentContract()
        {
            base.CreateRentContract();
            Console.WriteLine("Renting time is 1 years");
            Console.WriteLine("Tax for City People is 15% / contract");
        }
    }
}
