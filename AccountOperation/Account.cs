using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperation
{
    internal class Account
    {
        public string customerName;
        public string accountNumber;
        public double depositAmount;
        public double withDrawAmount;
        public double totalMoney;

        public double DepositMoney()
        {
            totalMoney = totalMoney + depositAmount;
            return totalMoney;


        }
        public double WitdrawMoney()
        {
            totalMoney = totalMoney - withDrawAmount;
            return totalMoney;


        }

    }
}
