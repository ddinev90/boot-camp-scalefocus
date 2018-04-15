using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampBank
{
    public class DANCreator
    {
        private static Random r = new Random();

        //Generate random number
        public static string GenerateRandomNumberLength(int length)
        {
            StringBuilder number = new StringBuilder();
            for (int i = 0; i <length; i++)
            {
                number.Append(r.Next(10));
            }
            return number.ToString();
        }

        //Generate random 5 digit number
        //Overloading like a boss
        public static string GenerateRandomNumberLength()
        {
            StringBuilder number = new StringBuilder();
            number.Append(r.Next(10000,99999));
            return number.ToString();
        }


        public static string GenerateDAN(BankAccount account)
        {
            StringBuilder dan = new StringBuilder();

            if(account.Type == "Savings Account")
            {
                dan.Append(1);
            }else
            {
                dan.Append(2);
            }

            dan.Append(account.SSN.ToString().Substring(account.SSN.ToString().Length - 3));
            dan.Append(GenerateRandomNumberLength());
            dan.Append(GenerateRandomNumberLength(3));
            
            return dan.ToString();
        }
    }
}
