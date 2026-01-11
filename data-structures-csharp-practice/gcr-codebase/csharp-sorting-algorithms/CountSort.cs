using System;

class CountSort
{
    // Method to sort ages using Counting Sort
    static void CountingSort(int[] arr)
    {
        int[] count = new int[19];

        // Count frequency of each age
        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i]]++;
        }

        int index = 0;

        // Rebuild sorted array
        for (int age = 10; age <= 18; age++)
        {
            while (count[age] > 0)
            {
                arr[index++] = age;
                count[age]--;
            }
        }
    }
	

    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ages = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter age (10–18):");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        CountingSort(ages);

        Console.WriteLine("Sorted Ages:");
        foreach (int a in ages)
        {
            Console.WriteLine(a);
        }
    
	}

}
