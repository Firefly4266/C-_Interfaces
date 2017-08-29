using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IBasicAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal Balance { get; }
    }
    interface IAccountInfo
    {
        string Owner { get; set; }
        int Id { get; }
    }
    interface IAccount : IBasicAccount, IAccountInfo
    {
    }
    interface IAccount2 : IAccount
    {
        void NewMethod();
    }
}
