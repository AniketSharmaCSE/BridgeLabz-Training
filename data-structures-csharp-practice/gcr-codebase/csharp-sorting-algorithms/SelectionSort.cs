using System;

class SelectionSort
{
    // Method to sort using Selection Sort
    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            // Find smallest element in remaining array
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        
		}
 
 }


    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter exam score:");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        SelectionSort(scores);
        Console.WriteLine("Sorted Scores:");
        foreach (int s in scores)
        {
            Console.WriteLine(s);
        }
    }
}
