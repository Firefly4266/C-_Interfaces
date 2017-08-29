using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal Balance { get; }
        string Owner { get; set; }
        int Id { get; }
    }
}
