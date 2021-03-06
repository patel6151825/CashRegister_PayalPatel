﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_PayalPatel
{
    class GUI
    {
        public void ShowMenu()
        {
            Console.WriteLine("\n\nCash Register");
        }

        public void EnterTransactionLine()
        {
            Console.Write("Enter Product name : ");
            string productName = Convert.ToString(Console.ReadLine());

        }

        public IAction ShowTransactionLine()
        {
            IAction operation = new AddTransactionLine();
            Console.WriteLine("\nEnter 1 For Add TransactionLine:");
            Console.WriteLine("Enter 2 For Delete TransactionLine:");
            Console.WriteLine("Enter 3 For Cancel TransactionLine:");
            Console.Write("choose Operation:");
            var op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    operation = new AddTransactionLine();
                    break;

                case 2:
                    operation = new DeleteTransactionLine();
                    break;

                case 3:
                    operation = new CancelTransactionLine();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            return operation;
        }
    }
}
