using System;

public class LogManager
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter maximum number of call logs:");
        int size = Convert.ToInt32(Console.ReadLine());

        
        CallLogManager manager = new CallLogManager(size);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search by Keyword");
            Console.WriteLine("3. Filter by Time Range");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

        
            if (choice == 1)
            {
                Console.WriteLine("Enter phone number:");
                string phone = Console.ReadLine();

            
                //Phone number validation
                if (phone.Length != 10)
                {
                    Console.WriteLine("Invalid phone number. Must be 10 digits");
                    continue;
                }


                Console.WriteLine("Enter message:");
                string message = Console.ReadLine();
                Console.WriteLine("Enter timestamp (yyyy-MM-dd HH:mm):");
                string timeInput = Console.ReadLine();

                DateTime time;
              
                if (!DateTime.TryParse(timeInput, out time))
                {
                    Console.WriteLine("Invalid time format");
                    continue;
                }

                CallLog log = new CallLog(phone, message, time);
                manager.AddCallLog(log);
            }

            else if (choice == 2)
            {
                Console.WriteLine("Enter keyword to search:");
                string keyword = Console.ReadLine();
                manager.SearchByKeyword(keyword);
            
            }
            
            else if (choice == 3)
            {
                Console.WriteLine("Enter start time (yyyy-MM-dd HH:mm):");
                string startInput = Console.ReadLine();
                Console.WriteLine("Enter end time (yyyy-MM-dd HH:mm):");
                string endInput = Console.ReadLine();


                DateTime start, end;


                if (!DateTime.TryParse(startInput, out start) || !DateTime.TryParse(endInput, out end)){
                    Console.WriteLine("Invalid time input");
                    continue;
                }


                if (start > end)
                {
                    Console.WriteLine("Start time cannot be after end time");
                    continue;
                }

                manager.FilterByTime(start, end);
            }

            else if (choice == 4)
            {
                Console.WriteLine("Exiting system");
                break;
            }
            
            else
            {
                Console.WriteLine("Invalid choice");
            
            }
        }
    
    
    }

}
