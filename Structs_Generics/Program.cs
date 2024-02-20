Point obj = new Point { };

Console.WriteLine(obj.X);
Console.WriteLine(obj.Y);
Console.WriteLine(obj.Z);
Console.WriteLine(obj.Delta);

DateTime dateTime = DateTime.Now;

Console.WriteLine(dateTime.Minute);
var changedDateTime = dateTime.AddMonths(13);

Console.WriteLine(changedDateTime);

// TimeSpan span = TimeSpan.FromHours(2);

TimeSpan span = new TimeSpan(1, 30, 45);

var increasedDateTime = dateTime.Add(span);
var diff = increasedDateTime.Subtract(dateTime);

Console.WriteLine($"span = {span}");
Console.WriteLine($"diff = {diff}");
Console.WriteLine($"diff.Seconds = {diff.Seconds}");
Console.WriteLine($"diff.TotalSeconds = {diff.TotalSeconds}");
Console.WriteLine($"{123:b8}");

Console.Read();




#region RefOutTests

int myNum = 5;

Increment(ref myNum);

GetValue(out int value);

Console.WriteLine(myNum);
Console.WriteLine(value);

void Increment(ref int num)
{
    num++;
}

void GetValue(out int value)
{
    value = 5;
}
#endregion

#region InterfaceTests

interface ITest
{
    int GetValue();
    void SetValue(int value);
}

abstract class Test : ITest
{
    public int GetValue()
    {
        return 42;
    }

    public void SetValue(int value)
    {
        
    }

    public virtual void DoAnotherThing() // virtual method
    {
        Console.WriteLine("Test.DoAnotherThing");
    }
    
    public abstract void DoSomething(); // pure virtual method
}

class Test2 : Test
{
    public Test2() : base()
    {
        
    }
    
    public override void DoAnotherThing()
    {
        //base.DoAnotherThing();

        Console.WriteLine("Test2.DoAnotherThing");
    }

    public override void DoSomething()
    {
        Console.WriteLine("Test2.DoSomething");
    }
}
#endregion


// ref - struct object always stored in stack

readonly ref struct Point
{
    public Point()
    {
        X = 0;
        Y = 0;
        Z = 0;
        Delta = 0;
    }

    public Point(int x, int y, int z, double delta)
    {
        X = x;
        Y = y;
        Z = z;
        Delta = delta;
    }
    
    public int X { get; }
    public int Y { get; init; }
    public int Z { get; init; }
    public double Delta { get; init; }
}
