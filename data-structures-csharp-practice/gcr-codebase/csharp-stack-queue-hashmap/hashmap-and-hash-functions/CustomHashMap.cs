using System;
using System.Collections.Generic;

class CustomHashMap
{
    private int size = 10;
    private LinkedList<KeyValuePair<int, int>>[] table;

    public CustomHashMap()
    {
        table = new LinkedList<KeyValuePair<int, int>>[size];
    }


    int Hash(int key)
    {
        return key % size;
    }


    // Insert or update value
    public void Put(int key, int value)
    {
        int index = Hash(key);

        if (table[index] == null)
        {
            table[index] = new LinkedList<KeyValuePair<int, int>>();
        }


        foreach (var pair in table[index])
        {
            if (pair.Key == key)
            {
                table[index].Remove(pair);
                table[index].AddLast(new KeyValuePair<int, int>(key, value));
                return;
            }
        }

        table[index].AddLast(new KeyValuePair<int, int>(key, value));
    }


    public int Get(int key)
    {
        int index = Hash(key);

        if (table[index] != null)
        {
            foreach (var pair in table[index])
            {
                if (pair.Key == key)
                {
                    return pair.Value;
                }
            }
        }


        return -1;
    }


    public void Remove(int key)
    {
        int index = Hash(key);

        if (table[index] != null)
        {
            foreach (var pair in table[index])
            {
                if (pair.Key == key)
                {
                    table[index].Remove(pair);
                    return;

                }

            }

        }

    }


    static void Main()
    {
        CustomHashMap map = new CustomHashMap();

        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(12, 300);

        Console.WriteLine(map.Get(2));
        map.Remove(2);
        Console.WriteLine(map.Get(2));
    }
}
