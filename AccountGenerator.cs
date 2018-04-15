using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BootCampBank
{
    class AccountGenerator
    {
        
        public static List<BankAccount> Generate()
        {
            List<string[]> accountsData = CSVReader.CSVParser();
            List<BankAccount> accounts = new List<BankAccount>();
            for(int i = 0; i< accountsData.Count; i++)
            {
                if ((accountsData[i])[3].ToString() == "Savings Account")
                {
                    accounts.Add(new SavingsAccount((accountsData[i])[0].ToString(),
                    (accountsData[i])[1].ToString(),
                    int.Parse((accountsData[i])[2].ToString()),
                   (accountsData[i])[3].ToString(),
                    double.Parse((accountsData[i])[4].ToString())));
                }
                else
                {
                    accounts.Add(new CheckingAccount((accountsData[i])[0].ToString(),
                    (accountsData[i])[1].ToString(),
                    int.Parse((accountsData[i])[2].ToString()),
                   (accountsData[i])[3].ToString(),
                    double.Parse((accountsData[i])[4].ToString())));
                }
                
            }
            return accounts;
        }
    }
}
