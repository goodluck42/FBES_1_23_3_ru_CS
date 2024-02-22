using System;
using System.Collections;
//
// int intValue = 10;
// object objValue = intValue; // boxing
// int fromHeap = (int)objValue; // unboxing;
//
//
// var arr = new ArrayList();
//
// arr.Add(10); // boxing
// arr.Add(20); // boxing
// arr.Add(30); // boxing
//
// int sum = 0;
//
// foreach (var value in arr)
// {
//     sum += (int)value; // unboxing
// }
//
// Console.WriteLine(sum);

var capacity = 100_000_000;

// List
{
    var begin = DateTime.Now;
    var list = new List<int>(capacity);
    
    for (int i = 0; i < capacity; i++)
    {
        list.Add(i);
    }
    
    for (int i = 0; i < capacity; i++)
    {
        int value = list[i];
    }

    Console.WriteLine($"generic: {(DateTime.Now - begin).TotalMilliseconds}");
}

// ArrayList
{
    var begin = DateTime.Now;
    var arrayList = new ArrayList(capacity);
    
    for (int i = 0; i < capacity; i++)
    {
        arrayList.Add(i);
    }
    
    for (int i = 0; i < capacity; i++)
    {
        int value = (int)arrayList[i]!;
    }

    Console.WriteLine($"non generic: {(DateTime.Now - begin).TotalMilliseconds}");
}