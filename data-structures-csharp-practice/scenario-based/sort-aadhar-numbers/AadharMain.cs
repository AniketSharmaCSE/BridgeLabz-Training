using System;
class AadharMain

{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of Aadhar records:");
        int n = Convert.ToInt32(Console.ReadLine());

        AadharRecord[] records = new AadharRecord[n];
        long[] aadharNumbers = new long[n];

        Console.WriteLine("Enter Aadhar numbers:");
        for (int i = 0; i < n; i++)
        {
            long input = Convert.ToInt64(Console.ReadLine());
            records[i] = new AadharRecord(input);
            aadharNumbers[i] = records[i].GetAadharNumber();
        }

        AadharService service = new AadharService();
        service.RadixSort(aadharNumbers);

        Console.WriteLine("\nSorted Aadhar Numbers:");
        for (int i = 0; i < n; i++)
        {
            if (aadharNumbers[i] != 0)
            {
                Console.WriteLine(aadharNumbers[i]);
            }
        }
    }
}
