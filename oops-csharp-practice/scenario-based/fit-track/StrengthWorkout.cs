using System;

class StrengthWorkout : Workout, ITrackable
{
    public int Sets;

    public StrengthWorkout(int duration, int sets)
        : base(duration)
    {
        Sets = sets;
    }

    //Implementation of tracking behavior
    public void TrackWorkout()
    {
        Console.WriteLine("Tracking Strength Workout with " + Sets + " sets");
    }

    //Override to display strength workout details
    public override void DisplayWorkout()
    {
        base.DisplayWorkout();
        Console.WriteLine("Sets: " + Sets);
    }
}
