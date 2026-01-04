using System;

public class HotelBooking
{
    string guestName;
    string roomType;
    int nights;


    //Default constructor
    public HotelBooking()
    {
        guestName = "not applicable";
        roomType = "Standard";
        nights = 1;
    }
	

    //Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights){
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }


    //Copy constructor
    public HotelBooking(HotelBooking h){
        this.guestName = h.guestName;
        this.roomType = h.roomType;
        this.nights = h.nights;
    }
	

    //Method to display booking details
    public void DisplayDetails()
    {
        Console.WriteLine(guestName + " " + roomType + " " + nights);
    }
}
