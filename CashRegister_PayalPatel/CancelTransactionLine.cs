using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_PayalPatel
{
    class CancelTransactionLine : IAction
    {
        public decimal ApplyAction(decimal price, int unit)
        {
            Console.WriteLine("Operation Canceled");
            return 0;
        }
    }
}
