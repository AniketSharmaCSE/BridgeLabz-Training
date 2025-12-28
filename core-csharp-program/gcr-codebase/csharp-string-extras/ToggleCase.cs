using System;

public class ToggleCase
{
	
	
    //Method to toggle character case
    static string ToggleCaseManually(string name)
    {
        string result = "";
        for (int i = 0; i < name.Length; i++)
        {
            char ch = name[i];
			//convert to lowercase
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
			//convert to uppercase
            else if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }

            result = result + ch;
        
		}
		
        return result;
    
	}

    
	
	static void Main(string[] args)
    {
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        string output = ToggleCaseManually(name);
        Console.WriteLine("Toggled case:");
        Console.WriteLine(output);
    }
}
