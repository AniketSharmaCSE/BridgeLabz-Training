using System;

class HomeLoan : LoanApplication
{
    public HomeLoan(Applicant applicant, int term)
        : base(applicant, term, 8.5)
    {
    }

    //different approval criteria for home loan
    public override bool ApproveLoan()
    {
        if (Applicant.GetCreditScore() >= 700)
        {
            return base.ApproveLoan();
        }
        return false;
    }
}
