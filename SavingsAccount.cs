using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampBank
{
    public class SavingsAccount : BankAccount
    {

        public int DepositBoxNumber { get; set; }
        public int DepositBoxPassword { get; set; }
        public SavingsAccount(string firstName, string lastName, int sSN, string type, double deposit) : base(firstName, lastName, sSN, type, deposit)
        {
           DepositBoxNumber = int.Parse(DANCreator.GenerateRandomNumberLength(3));
           DepositBoxPassword = int.Parse(DANCreator.GenerateRandomNumberLength(4));
           interestRate -= 0.25;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Deposit box number is:  {DepositBoxNumber}");
            Console.WriteLine($"Deposit box password is:  {DepositBoxPassword}");
            Console.WriteLine($"Interest rate is: {interestRate}");
            Console.WriteLine("------------------------------------------");
        }


    }
}
