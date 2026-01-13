using System;

public class MovieServiceImpl : IMovieService
{
    private Movie[] movies;
    private int movieCount;

    public MovieServiceImpl()
    {
        movies = new Movie[100];
        movieCount = 0;
    }

    //Method to add movie or showtime
    public void AddMovie(string title, string time)
    {
        Movie movie = FindMovie(title);

        if (movie == null)
        {
            if (movieCount < movies.Length)
            {
                movie = new Movie(title);
                movies[movieCount] = movie;
                movieCount++;
            }
        }

        if (movie != null)
        {
            movie.AddShowTime(time);
        }
    }

    //Method to search movie
    public void SearchMovie(string keyword)
    {
        bool found = false;

        for (int i = 0; i < movieCount; i++)
        {
            if (movies[i].Title.ToLower().Contains(keyword.ToLower()))
            {
                string times = "";

                for (int j = 0; j < movies[i].ShowTimeCount; j++)
                {
                    times = times + movies[i].ShowTimes[j];

                    if (j < movies[i].ShowTimeCount - 1)
                    {
                        times = times + ", ";
                    }
                }

                string output = string.Format("Movie: {0} | Showtimes: {1}", movies[i].Title, times);

                Console.WriteLine(output);
                Console.WriteLine();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No movie found with keyword: " + keyword);
        }
    }

    //Method to display all movies
    public void DisplayAllMovies()
    {
        if (movieCount == 0)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        for (int i = 0; i < movieCount; i++)
        {
            string times = "";

            for (int j = 0; j < movies[i].ShowTimeCount; j++)
            {
                times = times + movies[i].ShowTimes[j];

                if (j < movies[i].ShowTimeCount - 1)
                {
                    times = times + ", ";
                }
            }

            string output = "Movie: " + movies[i].Title + " | Showtimes: " + times;

            Console.WriteLine(output);
            Console.WriteLine();
        }
    }

    //Method to find movie by title
    private Movie FindMovie(string title)
    {
        for (int i = 0; i < movieCount; i++)
        {
            if (movies[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return movies[i];
            }
        }
        return null;
    }
}
