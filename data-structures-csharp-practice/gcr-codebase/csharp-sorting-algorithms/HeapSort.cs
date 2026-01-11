using System;

class HeapSort
{
    // Method to heapify subtree
    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }


    // Method to perform Heap Sort
    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }


    static void Main()
    {
        Console.WriteLine("Enter number of applicants:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] salary = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter expected salary:");
            salary[i] = Convert.ToInt32(Console.ReadLine());
        }

        HeapSort(salary);

        Console.WriteLine("Sorted Salary Demands:");
        foreach (int s in salary)
        {
            Console.WriteLine(s);
        }
    }
}
