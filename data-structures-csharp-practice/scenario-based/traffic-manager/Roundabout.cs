class Roundabout
{
    private VehicleNode tail;

    public void AddVehicle(string number)
    {
        VehicleNode newNode = new VehicleNode(number);

        if (tail == null)
        {
            tail = newNode;
            tail.Next = tail;
        }
        else
        {
            newNode.Next = tail.Next;
            tail.Next = newNode;
            tail = newNode;
        }

        Console.WriteLine($"Vehicle {number} entered roundabout.");
    }

    public void RemoveVehicle()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode head = tail.Next;

        if (head == tail)
        {
            Console.WriteLine($"Vehicle {head.VehicleNumber} exited.");
            tail = null;
        }
        else
        {
            Console.WriteLine($"Vehicle {head.VehicleNumber} exited.");
            tail.Next = head.Next;
        }
    }

    public void PrintState()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode temp = tail.Next;
        Console.Write("Roundabout: ");

        do
        {
            Console.Write(temp.VehicleNumber + " -> ");
            temp = temp.Next;
        } while (temp != tail.Next);

        Console.WriteLine("(back to start)");
    }
}
