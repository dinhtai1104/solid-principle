using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstutitionPrinciple.After_Liskov
{
    class RemoteAreaContract : DomesticPropertyContract
    {
        public RemoteAreaContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate) :
            base(buyer, contractName, createdDate, validDate)
        { }

        public override void CreateBuyContract()
        {
            base.CreateBuyContract();
            Console.WriteLine("Tax for Remote Area People is 5% / contract");
        }

        public override void CreateRentContract()
        {
            base.CreateRentContract();
            Console.WriteLine("Renting time is 10 years");
            Console.WriteLine("Tax for Remote Area People is 5% / contract");
        }
    }
}
