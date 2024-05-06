using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstutitionPrinciple.Before_Liskov
{
    class PropertyContract
    {
        public Buyer Buyer { get; private set; }
        public string ContractName { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime ValidDate { get; private set; }

        public PropertyContract(Buyer buyer, string contractName, DateTime createdDate, DateTime validDate)
        {
            Buyer = buyer;
            ContractName = contractName;
            CreatedDate = createdDate;
            ValidDate = validDate;
        }

        public virtual void CreateRentContract()
        {
            Console.WriteLine("Renting Contract created sucessull!.");
            Console.WriteLine($@"Buyer Information: Name: {Buyer.Name}, Phone: {Buyer.PhoneNumber}, Address: {Buyer.Address}");
        }

        public virtual void CreateBuyContract()
        {
            Console.WriteLine("Buying Contract created sucessull!.");
            Console.WriteLine($@"Buyer Information: Name: {Buyer.Name}, Phone: {Buyer.PhoneNumber}, Address: {Buyer.Address}");
        }

        public virtual void PrintContractInfo()
        {
            Console.WriteLine($"Contact Information: Name {ContractName}, Created Date {CreatedDate}, Valid Date {ValidDate}");
        }
    }
}
