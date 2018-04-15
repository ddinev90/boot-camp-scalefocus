using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampBank
{
    class CheckingAccount : BankAccount
    {
        public long DebitCardNumber { get; set; }
        public int DebitCardPin { get; set; }

        public CheckingAccount(string firstName, string lastName, int sSN, string type, double deposit) : base(firstName, lastName, sSN, type, deposit)
        {
            DebitCardNumber = Int64.Parse(DANCreator.GenerateRandomNumberLength(12));
            DebitCardPin = int.Parse(DANCreator.GenerateRandomNumberLength(4));
            
        }

        //overriding like a boss!
        public override void ShowInfo()
        {

            base.ShowInfo();
            Console.WriteLine($"Debit Card Number is {DebitCardNumber}");
            Console.WriteLine($"Debit card number pin is {DebitCardPin}");
            Console.WriteLine($"Interest rate is: {interestRate}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
