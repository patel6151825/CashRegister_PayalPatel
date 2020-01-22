using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_PayalPatel
{
    //interface to choose action
    interface IAction
    {
        decimal ApplyAction(decimal price,int unit);
    }
}
