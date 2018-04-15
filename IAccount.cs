using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampBank
{
    public interface IAccount
    {

        void DepositMoney(double sumDeposited);
        void Withdraw(double sumWithdrawn);
        void Transfer(BankAccount account, double sumTransferred);
        void ShowInfo();
    }
}
