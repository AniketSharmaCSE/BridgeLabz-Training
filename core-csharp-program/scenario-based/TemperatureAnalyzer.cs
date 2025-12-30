using System;

public class TemperatureAnalyzer
{
    // Method to analyze weekly temperature data
    static void AnalyzeTemperatures(float[,] temperatures)
    {
        int hottestDay = 0;
        int coldestDay = 0;

        float maxTemp = temperatures[0, 0];
        float minTemp = temperatures[0, 0];

        float[] dailyAverage = new float[7];
        // Loop through each day
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;

            // Loop through 24 hours of the day
            for (int hour = 0; hour < 24; hour++)
            {
                float currentTemp = temperatures[day, hour];
                sum = sum + currentTemp;

                // Check for hottest temperature
                if (currentTemp > maxTemp)
                {
                    maxTemp = currentTemp;
                    hottestDay = day;
                }

                // Check for coldest temperature
                if (currentTemp < minTemp)
                {
                    minTemp = currentTemp;
                    coldestDay = day;
                }
            }

            // Calculate average temperature of the day
            dailyAverage[day] = sum / 24;
        }

        Console.WriteLine("Hottest day index: " + hottestDay + " with temperature " + maxTemp);
        Console.WriteLine("Coldest day index: " + coldestDay + " with temperature " + minTemp);

        Console.WriteLine("Average temperature per day:");
        for (int i = 0; i < dailyAverage.Length; i++)
        {
            Console.WriteLine("Day " + i + ": " + dailyAverage[i]);
        }
    }

    static void Main(string[] args)
    {
        // Sample data for 7 days and 24 hours
        float[,] temperatures = new float[7, 24];

        // Taking input for temperatures
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("Enter temperatures for day " + day);
            for (int hour = 0; hour < 24; hour++)
            {
                temperatures[day, hour] = Convert.ToSingle(Console.ReadLine());
            }
        }

        AnalyzeTemperatures(temperatures);
    }
}
