using System;

public class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem()
    {
        //mark book as reserved
        isAvailable = false;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
