using System;

class AtmScenario
{
    public static void RunScenarioA(int amount)
    {
        Console.WriteLine("\nScenario A: All notes available");
        int[] notesA = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
        ATMDispenser.DispenseCash(amount, notesA);
    }

    public static void RunScenarioB(int amount)
    {
        Console.WriteLine("\nScenario B: ₹500 note unavailable");
        int[] notesB = { 1, 2, 5, 10, 20, 50, 100, 200 };
        ATMDispenser.DispenseCash(amount, notesB);
    }
}
