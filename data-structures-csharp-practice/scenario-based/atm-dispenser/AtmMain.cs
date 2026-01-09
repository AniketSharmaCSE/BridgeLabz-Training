using System;

class AtmMain
{
    static void Main()
    {
        Console.WriteLine("Enter amount to withdraw:");
        int amount = Convert.ToInt32(Console.ReadLine());

        ATMScenario.RunScenarioA(amount);
        ATMScenario.RunScenarioB(amount);
    }
}
