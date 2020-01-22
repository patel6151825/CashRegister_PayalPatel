using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_PayalPatel
{
    class CashRegister
    {
        public decimal TotalAmount { get; set; }
        public decimal TransactionTotal { get; set; }
        public decimal StartAmount { get; set; }
        public decimal price { get; set; }
        public int unit { get; set; }

        public CashRegister(decimal _StartAmount)
        {
            this.StartAmount = _StartAmount;
        }
        public decimal DoTransactionLine(IAction operation)
        {
            TotalAmount=operation.ApplyAction(price,unit);
            TransactionTotal = StartAmount + TotalAmount;
            Console.WriteLine($"Total Amount is {TotalAmount}");
            return TransactionTotal;
        }

        public void CloseRegister()
        {
            
        }
    }
}
