using System;

class BubbleSort
{
    static void BubbleSort(int[] arr)
    {
        //Outer loop to iterate the array
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //Inner loop to compare adjacent elements
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
					// Swap if order is wrong
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                
				}
            }
        
		}
    }
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] marks = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter mark:");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        BubbleSort(marks);
        Console.WriteLine("Sorted Marks:");
        
		foreach (int m in marks)
        {
            Console.WriteLine(m);
        }
    }
}
