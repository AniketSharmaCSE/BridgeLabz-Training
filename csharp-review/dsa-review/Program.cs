using System;

class CustomStack
{
    int[] stack;
    int top;
    int size;

    public CustomStack(int size){
        this.size = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == size - 1) {
            Console.WriteLine("Stack overflow");
            return;
        }
        top++;
        stack[top] = value;


    }

    public int Pop(){
        if (top == -1){
            return -1;
        }
        int value = stack[top];
        top--;
        return value;

    }

    public bool IsEmpty(){
        return top == -1;
    }

    public void InsertAtBottom(int value){
        if (IsEmpty())
        {
            Push(value);
            return;
        }

        int temp = Pop();
        InsertAtBottom(value);
        Push(temp);
    }

    public void Display() {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        for (int i = top; i >= 0; i--) {
            Console.Write(stack[i] + " ");
        }
        Console.WriteLine();
  
    }

}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter stack size: ");
        int size = int.Parse(Console.ReadLine());

        CustomStack stack = new CustomStack(size);

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter stack elements:");
        
        for (int i = 0; i < n; i++) {
            int value = int.Parse(Console.ReadLine());
            stack.Push(value);
        }

        Console.Write("Enter element to insert at bottom: ");
        int bottomValue = int.Parse(Console.ReadLine());

        stack.InsertAtBottom(bottomValue);

        Console.WriteLine("Stack after inserting at bottom:");
        stack.Display();
    
    }

}
