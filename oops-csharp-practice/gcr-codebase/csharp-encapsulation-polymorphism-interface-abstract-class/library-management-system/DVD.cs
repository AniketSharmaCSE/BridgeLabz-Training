using System;

public class DVD : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem()
    {
        //mark dvd as reserved
        isAvailable = false;
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
