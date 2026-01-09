using System;

class CardioWorkout : Workout, ITrackable
{
    public string CardioType;

    public CardioWorkout(int duration, string cardioType)
        : base(duration)
    {
        CardioType = cardioType;
    }

    //Implementation of tracking behavior
    public void TrackWorkout()
    {
        Console.WriteLine("Tracking Cardio Workout: " + CardioType);
    }

    //Override to display cardio workout details
    public override void DisplayWorkout()
    {
        base.DisplayWorkout();
        Console.WriteLine("Cardio Type: " + CardioType);
    }
}
