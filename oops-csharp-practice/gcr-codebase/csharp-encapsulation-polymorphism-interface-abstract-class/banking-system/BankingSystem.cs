using System;

class BankingSystem
{
    static void Main()
    {
        BankAccount[] accountList = new BankAccount[2];

        Console.WriteLine("Enter Savings Account Details");
        Console.Write("Account Number: ");
        string savingsAccountNumber = Console.ReadLine();
        Console.Write("Account Holder Name: ");
        string savingsAccountHolderName = Console.ReadLine();

        SavingsAccount savingsAccount = new SavingsAccount();
        savingsAccount.AccountNumber = savingsAccountNumber;
        savingsAccount.AccountHolderName = savingsAccountHolderName;

        Console.Write("Deposit Amount: ");
        double savingsDepositAmount = Convert.ToDouble(Console.ReadLine());
        savingsAccount.Deposit(savingsDepositAmount);
        Console.Write("Loan Amount Required: ");
        double savingsLoanAmount = Convert.ToDouble(Console.ReadLine());
        savingsAccount.ApplyForLoan(savingsLoanAmount);

        accountList[0] = savingsAccount;

        Console.WriteLine("\nEnter Current Account Details");
        Console.Write("Account Number: ");
        string currentAccountNumber = Console.ReadLine();
        Console.Write("Account Holder Name: ");
        string currentAccountHolderName = Console.ReadLine();

        CurrentAccount currentAccount = new CurrentAccount();
        currentAccount.AccountNumber = currentAccountNumber;
        currentAccount.AccountHolderName = currentAccountHolderName;

        Console.Write("Deposit Amount: ");
        double currentDepositAmount = Convert.ToDouble(Console.ReadLine());
        currentAccount.Deposit(currentDepositAmount);

        accountList[1] = currentAccount;

        Console.WriteLine("\nAccount Interest Details");

        for (int index = 0; index < accountList.Length; index++)
        {
            double interestAmount = accountList[index].CalculateInterest();

            Console.WriteLine("Account Number: " + accountList[index].AccountNumber);
            Console.WriteLine("Interest: " + interestAmount);

            //check loan eligibility only for loanable accounts
            if (accountList[index] is ILoanable)
            {
                ILoanable loanableAccount = (ILoanable)accountList[index];
                Console.WriteLine("Loan Eligible: " + loanableAccount.CalculateLoanEligibility());
            }

            Console.WriteLine();

        }

    }
}
