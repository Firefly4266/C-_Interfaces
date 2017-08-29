using System;


interface IBasicAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    decimal Balance { get; }
}
public class Account : IBasicAccount
{
    private decimal balance;
    public Account(decimal balance)
    {
        this.balance = balance;
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        balance -= amount;
    }
    public decimal Balance
    {
        get
        {
            return balance;
        }
    }
}