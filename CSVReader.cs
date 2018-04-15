using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampBank
{
    public class CSVReader
    {
        
        private static string path = System.IO.Path.GetFullPath("Account.csv");
        private static string line = "";
        private static char splitter = ',';

        

        public static List<string[]> CSVParser()
        {
            StreamReader reader = new StreamReader(path);

            List<string[]> accounts = new List<string[]>();
            while ((line = reader.ReadLine()) != null)
            {
                string[] accountData = line.Split(splitter);
                accounts.Add(accountData);
            }
            return accounts;
        }
    }
}
