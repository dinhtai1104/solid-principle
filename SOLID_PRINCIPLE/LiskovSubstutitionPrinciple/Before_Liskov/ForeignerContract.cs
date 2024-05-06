using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstutitionPrinciple.Before_Liskov
{
    class ForeignerContract : PropertyContract
    {
        public ForeignerContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate) :
            base(buyer, contractName, createdDate, validDate)
        { }

        public override void CreateBuyContract()
        {
            throw new Exception("Foreigner cannot buy property in Viet Nam");
        }

        public override void CreateRentContract()
        {
            base.CreateRentContract();
            Console.WriteLine("Renting time is 50 years");
            Console.WriteLine("Tax for Remote Area People is 15% / contract");
        }
    }
}
