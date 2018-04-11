using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampBank
{
    public interface IAccount
    {

        double Deposit();
        double Withdraw();
        double Transfer();
        void ShowInfo();

    }
}
