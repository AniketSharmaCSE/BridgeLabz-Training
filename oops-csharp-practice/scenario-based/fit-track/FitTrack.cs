using System;

class FitTrack
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter user name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        UserProfile user = new UserProfile(name, age);
        user.DisplayUser();

        Console.WriteLine("Select workout type:");
        Console.WriteLine("1.Cardio");
        Console.WriteLine("2.Strength");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter duration in minutes:");
        int duration = Convert.ToInt32(Console.ReadLine());

        Workout workout;
        ITrackable trackable;

        if (choice == 1)
        {
            Console.WriteLine("Enter cardio type:");
            string cardioType = Console.ReadLine();

            CardioWorkout cardio = new CardioWorkout(duration, cardioType);
            workout = cardio;
            trackable = cardio;
        }
        else
        {
            Console.WriteLine("Enter number of sets:");
            int sets = Convert.ToInt32(Console.ReadLine());

            StrengthWorkout strength = new StrengthWorkout(duration, sets);
            workout = strength;
            trackable = strength;
        }

        workout.DisplayWorkout();
        trackable.TrackWorkout();
    }
}
