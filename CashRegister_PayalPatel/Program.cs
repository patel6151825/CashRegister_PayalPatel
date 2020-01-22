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
            CashRegister register = new CashRegister(StartAmount);
            GUI display = new GUI();
            while (yesToContinue)
            {
                display.ShowMenu();
                display.EnterTransactionLine();
                display.ShowTransactionLine();
                Console.Write("Continue: Y/N ");
                var contKey = Console.ReadKey();
                yesToContinue = ((contKey.Key == ConsoleKey.Y) ? true : false);
            }
            
        }
    }
}
