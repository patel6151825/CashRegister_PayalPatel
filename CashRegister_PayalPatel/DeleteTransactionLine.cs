using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_PayalPatel
{
    class DeleteTransactionLine : IAction
    {
        decimal TotalAmount = 0;
        public decimal ApplyAction(decimal price, int unit)
        {
            decimal NewPrice = price * unit;
            TotalAmount = TotalAmount - NewPrice;
            Console.WriteLine("Product Deleted");
            return TotalAmount;
        }
    }
}
