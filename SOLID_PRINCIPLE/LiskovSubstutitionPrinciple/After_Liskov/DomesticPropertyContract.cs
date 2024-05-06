using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstutitionPrinciple.After_Liskov
{
    class DomesticPropertyContract : PropertyContract
    {
        public DomesticPropertyContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate)
            :base(buyer, contractName, createdDate, validDate) { }

        public virtual void CreateBuyContract()
        {
            Console.WriteLine("Buying Contract created sucessull!.");
            Console.WriteLine($@"Buyer Information: Name: {Buyer.Name}, Phone: {Buyer.PhoneNumber}, Address: {Buyer.Address}");
        }

        public virtual void CreateRentContract()
        {
            Console.WriteLine("Renting Contract created sucessull!.");
            Console.WriteLine($@"Buyer Information: Name: {Buyer.Name}, Phone: {Buyer.PhoneNumber}, Address: {Buyer.Address}");
        }
    }
}
