using System;

public class CurrentAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return balance * 0.02;
    }
}
