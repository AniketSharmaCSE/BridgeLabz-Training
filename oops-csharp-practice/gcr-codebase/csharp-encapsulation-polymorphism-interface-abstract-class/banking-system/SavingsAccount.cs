using System;

public class SavingsAccount : BankAccount, ILoanable
{
    private double requestedLoanAmount;

    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan(double loanAmount)
    {
        requestedLoanAmount = loanAmount;
    }

    public bool CalculateLoanEligibility()
    {
        //simple eligibility rule
        if (balance >= 5000)
        {
            return true;
        }
        return false;
    }
}
