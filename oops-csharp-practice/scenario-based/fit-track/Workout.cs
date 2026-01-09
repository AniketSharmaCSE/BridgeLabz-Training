using System;

class Workout
{
    public int Duration;

    public Workout(int duration)
    {
        Duration = duration;
    }

    //Method to display workout duration
    public virtual void DisplayWorkout()
    {
        Console.WriteLine("Duration: " + Duration + " minutes");
    }
}
