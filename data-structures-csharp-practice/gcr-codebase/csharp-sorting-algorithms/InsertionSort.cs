using System;


class InsertionSort
{
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // Shift elements 
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
    
    }
    }
	

    static void Main()
    {
        Console.WriteLine("Enter number of employees:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ids = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter employee ID:");
            ids[i] = Convert.ToInt32(Console.ReadLine());
        }

        InsertionSort(ids);
        Console.WriteLine("Sorted Employee IDs:");
        
		foreach (int id in ids)
        {
            Console.WriteLine(id);
        }
    }
}
