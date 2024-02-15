var num1 = new Number(42);
var num2 = new Number(13);
var res = num1 + num2; // left = Number; right = Number
//var res2 = num1 + 10; // left = Number; right = int


Console.WriteLine($"result: {(string)num1}");
Console.WriteLine(num1);

if (num1)
{
    
}

if (num1.Equals(num2))
{
    Console.WriteLine("Equals");
}
else
{
    Console.WriteLine("Not equals");
}

var myArr = new MyArray(10, 20, 30, 40, 50);

Console.WriteLine(myArr[0]); // int
Console.WriteLine(myArr[1..3]); // Range
Console.WriteLine(myArr[2]); // Index


class Number
{
    public Number(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public static Number operator+(Number left, Number right)
    {
        var result = new Number(left.Value + right.Value);
        
        return result;
    }
    
    public static Number operator-(Number self)
    {
        return new Number(-self.Value);
    }
    
    public static bool operator true(Number self)
    {
        return self.Value != 0;
    }

    public static bool operator false(Number self)
    {
        return self.Value == 0;
    }

    // public static bool operator ==(Number left, Number right)
    // {
    //     return left.Value == right.Value;
    // }
    //
    // public static bool operator !=(Number left, Number right)
    // {
    //     return left.Value != right.Value;
    // }

    public override bool Equals(object? obj)
    {
        //// variant 1
        // bool result = obj is Number;
        //
        // if (result)
        // {
        //     Number number = (obj as Number)!;
        //
        //     return number.Value == Value;
        // }
        //// variant 2

        if (obj is Number casted)
        {
            return casted.Value == Value;
        }
        
        return false;
    }
    
    public static implicit operator string(Number self)
    {
        return self.Value.ToString();
    }
    
    public string ToMyString()
    {
        return Value.ToString();
    }
}

class MyArray
{
    private int[] _values;

    public MyArray(params int[] values)
    {
        _values = values;
    }
    
    // public int this[int index]
    // {
    //     get => _values[index];
    //     set => _values[index] = value;
    // }

    public MyArray this[Range range]
    {
        get
        {
            return new MyArray();
        }
    }
    
    public int this[Index index]
    {
        get
        {
            if (index.IsFromEnd)
            {
                return _values[_values.Length - index.Value];
            }

            return _values[index.Value];
        }

        set
        {
            // TODO: Write setter
        }
    }
}