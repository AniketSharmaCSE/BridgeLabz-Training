using System;

class ExceptionPropagation
{
    //Method that causes arithmetic exception
    static void Method1()
    {
        int result = 10 / 0;
    }

    //Method calling Method1 without handling exception
    static void Method2()
    {
        Method1();
    }

    static void Main(string[] args)
    {
        try
        {
            //Calling Method2 which internally calls Method1
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
