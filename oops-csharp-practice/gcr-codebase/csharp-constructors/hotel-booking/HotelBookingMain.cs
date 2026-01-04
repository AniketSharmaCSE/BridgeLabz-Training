using System;

public class HotelBookingMain
{
    static void Main(string[] args)
    {
        //Using default constructor
        HotelBooking b1 = new HotelBooking();
        //Using parameterized constructor
        HotelBooking b2 = new HotelBooking("Aniket", "Deluxe", 3);
        //Using copy constructor
        HotelBooking b3 = new HotelBooking(b2);

        b1.DisplayDetails();
        b2.DisplayDetails();
        b3.DisplayDetails();
    }
}
