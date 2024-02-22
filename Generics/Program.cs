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

var myList = new MyList<int> { 10, 20, 30 };
using var enumerator = myList.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

enumerator.Reset();


// BENCHMARK

#region BENCHMARK

#if _
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
#endif

#endregion

interface IMyList<T>
{
    void Add(T value);
    void Remove(T value);

    int Length { get; }
    T this[int index] { get; set; }
}

class MyList<T> : IMyList<T>, IEnumerable<T>
{
    private class MyListEnumerator : IEnumerator<T>
    {
        private readonly T[] _values;
        private int _currentIndex;

        public MyListEnumerator(T[] values)
        {
            _values = values;
            _currentIndex = -1;
        }

        public bool MoveNext()
        {
            if (_currentIndex == _values.Length - 1)
            {
                return false;
            }

            _currentIndex += 1;

            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public T Current => _values[_currentIndex];

        object IEnumerator.Current => Current!;

        public void Dispose()
        {
        }
    }

    private T[] _values;

    public MyList(params T[] @params)
    {
        _values = new T[@params.Length];

        for (int i = 0; i < _values.Length; i++)
        {
            _values[i] = @params[i];
        }

        Length = @params.Length;
    }

    public void Add(T value)
    {
        Console.WriteLine("added");
        // TODO: implement method
    }

    public void Remove(T value)
    {
        // TODO: implement method
    }

    public int Length { get; private set; }

    public T this[int index]
    {
        get => _values[index];
        set => _values[index] = value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new MyListEnumerator(_values);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}