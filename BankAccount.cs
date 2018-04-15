using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace BootCampBank
{
    public class BankAccount: IAccount
    {
        public CSVReader CSVReader = new CSVReader();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Type { get; set; }
        public double Deposit { get; set; }
        public string DAN { get; set; }
        public double interestRate;
        

        public BankAccount(string firstName,string lastName,int sSN,string type,double deposit){
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = sSN;
            this.Type = type; 
            this.Deposit = deposit;
            this.DAN = DANCreator.GenerateDAN(this).ToString();
            interestRate = 3;
            }
        
        

        public void DepositMoney(double sumDeposited)
        {
            this.Deposit += sumDeposited;
        }

         public void Withdraw(double sumWithdrawn)
        {
            this.Deposit -= sumWithdrawn;
        }

         public void Transfer(BankAccount account,double sumTransferred)
        {
            account.DepositMoney(sumTransferred);
        }

         public virtual void ShowInfo()
        {
            Console.WriteLine($"This account is {this.Type}");
            Console.WriteLine($"Owner of this account is {this.FirstName}, {this.LastName}");
            Console.WriteLine($"Social Security number is {this.SSN}");
            Console.WriteLine($"Digital account number is {this.DAN}");
            Console.WriteLine($"Their current amount is {this.Deposit}");
            
        }
    }
}
