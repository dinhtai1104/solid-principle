using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstutitionPrinciple.After_Liskov
{
    class InternationalPropertyContract : PropertyContract
    {
        public InternationalPropertyContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate)
            :base(buyer, contractName, createdDate, validDate) { }

        public virtual void CreateRentContract()
        {
            Console.WriteLine("Renting Contract created sucessull!.");
            Console.WriteLine($@"Buyer Information: Name: {Buyer.Name}, Phone: {Buyer.PhoneNumber}, Address: {Buyer.Address}");
        }
    }
}
