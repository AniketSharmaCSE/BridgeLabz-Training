using System;

public class CinemaTimeApp
{
    public static void Main(string[] args)
    {
        IMovieService movieService = new MovieServiceImpl();

        while (true)
        {
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. Display All Movies");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter movie title:");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter showtime(HH:MM):");
                        string time = Console.ReadLine();

                        movieService.AddMovie(title, time);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter keyword to search:");
                        string keyword = Console.ReadLine();

                        movieService.SearchMovie(keyword);
                        break;
                    }

                case 3:
                    {
                        movieService.DisplayAllMovies();
                        break;
                    }

                case 4:
                    {
                        return;
                    }

                default:
                    {
                        Console.WriteLine("Invalid choice.");
                        break;
                    }
            }
        }
    }
}
