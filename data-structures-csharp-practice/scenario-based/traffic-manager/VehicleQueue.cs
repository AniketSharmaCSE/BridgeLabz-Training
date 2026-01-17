class VehicleQueue
{
    private string[] queue;
    private int front, rear, size, capacity;

    public VehicleQueue(int capacity)
    {
        this.capacity = capacity;
        queue = new string[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    public bool IsFull() => size == capacity;
    public bool IsEmpty() => size == 0;

    public void Enqueue(string vehicle)
    {
        if (IsFull())
        {
            Console.WriteLine("Queue Overflow: Waiting line is full.");
            return;
        }

        rear = (rear + 1) % capacity;
        queue[rear] = vehicle;
        size++;
        Console.WriteLine($"Vehicle {vehicle} added to waiting queue.");
    }

    public string Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow: No vehicles waiting.");
            return null;
        }

        string vehicle = queue[front];
        front = (front + 1) % capacity;
        size--;
        return vehicle;
    }
}
