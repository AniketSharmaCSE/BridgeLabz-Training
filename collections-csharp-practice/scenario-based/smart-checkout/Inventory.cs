using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<string, int> priceMap = new Dictionary<string, int>();
    private Dictionary<string, int> stockMap = new Dictionary<string, int>();

    // Manager adds item
    public void AddItem()
    {
        Console.Write("Item name: ");
        string item = Console.ReadLine();

        Console.Write("Price: ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Stock: ");
        int stock = int.Parse(Console.ReadLine());

        priceMap[item] = price;
        stockMap[item] = stock;

        Console.WriteLine("Item added to inventory");
    }

    // Manager deletes item
    public void RemoveItem()
    {
        Console.Write("Enter item name to delete: ");
        string item = Console.ReadLine();

        if (priceMap.ContainsKey(item))
        {
            priceMap.Remove(item);
            stockMap.Remove(item);
            Console.WriteLine("Item removed");
        }
        else
        {
            Console.WriteLine("Item not found");
        }
    }

    // Manager views inventory
    public void ViewInventory()
    {
        Console.WriteLine("\nInventory:");
        foreach (var item in priceMap.Keys)
        {
            Console.WriteLine(item + " | Price: " + priceMap[item] +
                               " | Stock: " + stockMap[item]);
        }
    }

    // Cashier uses these methods
    public bool IsItemAvailable(string item)
    {
        return stockMap.ContainsKey(item) && stockMap[item] > 0;
    }

    public int GetPrice(string item)
    {
        return priceMap[item];
    }

    public void UpdateStock(string item)
    {
        stockMap[item] = stockMap[item] - 1;
    }
}
