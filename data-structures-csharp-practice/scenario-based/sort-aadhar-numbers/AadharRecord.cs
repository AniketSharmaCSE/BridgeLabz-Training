using System;

public class AadharRecord
{
    private long aadharNumber;

    //Constructor
    public AadharRecord(long aadharNumber)
    {
        //checking is entered number is 12 digits
        if (!IsValidAadhar(aadharNumber))
        {
            Console.WriteLine("Invalid Aadhar number (must be 12 digits)");
            this.aadharNumber = 0;
        }
        else
        {
            this.aadharNumber = aadharNumber;
        }
    }

    //Getter method
    public long GetAadharNumber()
    {
        return aadharNumber;
    }

    //method to check if aadhar is 12 digits
    private bool IsValidAadhar(long number)
    {
        int count = 0;

        while (number > 0)
        {
            count++;
            number = number / 10;
        }

        return count == 12;
    }
}
