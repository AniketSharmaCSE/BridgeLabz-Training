using System;

class BrowserBuddy
{
    static void Main(string[] args)
    {
        Browser browser = new Browser();
        int choice;

        do
        {
            Console.WriteLine("\n1. Open Page");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Close Tab");
            Console.WriteLine("5. Restore Tab");
            Console.WriteLine("6. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter URL:");
                    string url = Console.ReadLine();
                    browser.OpenPage(url);
                    break;

                case 2:
                    browser.Back();
                    break;

                case 3:
                    browser.Forward();
                    break;

                case 4:
                    browser.CloseTab();
                    break;

                case 5:
                    browser.RestoreTab();
                    break;

                case 6:
                    Console.WriteLine("Browser closed");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 6);
    }
}
