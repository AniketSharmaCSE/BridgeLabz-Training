using System;

class SmartHomeMain
{
    static void Main()
    {
        Light light = new Light("Light");
        Fan fan = new Fan("Fan");
        AC ac = new AC("AC");

        while (true)
        {
            Console.WriteLine("\nSmart Home Menu");
            Console.WriteLine("1. Light ON");
            Console.WriteLine("2. Light OFF");
            Console.WriteLine("3. Fan ON");
            Console.WriteLine("4. Fan OFF");
            Console.WriteLine("5. AC ON");
            Console.WriteLine("6. AC OFF");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    light.TurnOn();
                    break;

                case 2:
                    light.TurnOff();
                    break;

                case 3:
                    fan.TurnOn();
                    break;

                case 4:
                    fan.TurnOff();
                    break;

                case 5:
                    ac.TurnOn();
                    break;

                case 6:
                    ac.TurnOff();
                    break;

                case 7:
                    Console.WriteLine("Exiting Smart Home");
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
