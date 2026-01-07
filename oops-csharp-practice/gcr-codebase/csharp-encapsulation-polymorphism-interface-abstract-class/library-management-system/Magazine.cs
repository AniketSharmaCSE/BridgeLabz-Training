using System;

public class Magazine : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public override int GetLoanDuration()
    {
        return 7;
    }

    public void ReserveItem()
    {
        //mark magazine as reserved
        isAvailable = false;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
