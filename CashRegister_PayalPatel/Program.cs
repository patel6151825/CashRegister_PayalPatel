using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_PayalPatel
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal StartAmount = 1000;
            bool yesToContinue = true;
            GUI display = new GUI();
            while (yesToContinue)
            {
                display.ShowMenu();
                display.EnterTransactionLine();

                Console.Write("Enter Unit Price : ");
                decimal Price = decimal.Parse(Console.ReadLine());

                Console.Write("Enter Number of Units : ");
                int Unit = Convert.ToInt32(Console.ReadLine());

                IAction operation=display.ShowTransactionLine();
                CashRegister register = new CashRegister(StartAmount);
                register.price = Price;
                register.unit = Unit;

                decimal TransactionTotal=register.DoTransactionLine(operation);
                register.StartAmount = TransactionTotal;
                Console.WriteLine($"Transaction Total Amount is {TransactionTotal}");
                Console.Write("Continue: Y/N ");
                var contKey = Console.ReadKey();
                yesToContinue = ((contKey.Key == ConsoleKey.Y) ? true : false);
            }
            
        }
    }
}
