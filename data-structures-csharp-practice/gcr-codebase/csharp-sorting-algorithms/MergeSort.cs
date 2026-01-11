using System;

class MergeSort
{
    // Method to merge two sorted halves
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int SizeLeft = mid - left + 1;
        int SizeRight = right - mid;

        int[] L = new int[SizeLeft];
        int[] R = new int[SizeRight];

        for (int i = 0; i < SizeLeft; i++)
        {
            L[i] = arr[left + i];
        }

        for (int j = 0; j < SizeRight; j++)
        {
            R[j] = arr[mid + 1 + j];
        }

        int iIndex = 0, jIndex = 0, k = left;


        // Merge both arrays in sorted order
        while (iIndex < SizeLeft && jIndex < SizeRight)
        {
            if (L[iIndex] <= R[jIndex])
            {
                arr[k] = L[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = R[jIndex];
                jIndex++;
            }
            k++;
        }


        while (iIndex < SizeLeft)
        {
            arr[k++] = L[iIndex++];
        }

        while (jIndex < SizeRight)
        {
            arr[k++] = R[jIndex++];
        }
    }


    // Method to perform Merge Sort
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);

        }
    }


    static void Main()
    {
        Console.WriteLine("Enter number of books:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] prices = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter book price:");
            prices[i] = Convert.ToInt32(Console.ReadLine());
        }

        MergeSort(prices, 0, n - 1);

        Console.WriteLine("Sorted Book Prices:");
        foreach (int p in prices)
        {
            Console.WriteLine(p);
        }
    }
}
