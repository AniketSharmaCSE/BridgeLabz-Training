using System;

class Chef : Person, Worker
{
    public string SpecialDish;

    public Chef(string name, int id, string specialDish)
        : base(name, id)
    {
        SpecialDish = specialDish;
    }

    //Implementation of interface method
    public void PerformDuties()
    {
        Console.WriteLine(Name + " is cooking " + SpecialDish);
    }
}
