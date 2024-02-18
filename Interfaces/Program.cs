// List<IMovable> movableObjects = new List<IMovable>();
//
// movableObjects.Add(new Cat());
// movableObjects.Add(new Car());
// movableObjects.Add(new Bird());
//
// foreach (var @object in movableObjects)
// {
//     @object.Move();
// }

// var storage = new Storage();
//
// storage.Add(new Bird());
// storage.Add(new Cat());
// storage.Add(new Car());

// var obj = new MyClass();
// var ib = obj as IA;
//
// ib?.ToList();

// using System.Text;
//
// var stringBuilder = new StringBuilder();
//
// stringBuilder.Append("Hello");
// stringBuilder.Append("World");
//
// var res = stringBuilder.ToString();
//
// Console.WriteLine(stringBuilder.ToString());
/////////////////////////

var obj = new MyObject()
{
    Text = "Helloy",
    Value = 13
};

MyProgram.ChangeObject(ref obj);
MyProgram.GetObject(out var obj2);



Console.WriteLine(obj2.Text);
Console.WriteLine(obj2.Value);

Console.WriteLine(obj.Text);
Console.WriteLine(obj.Value);
Console.Read();
/// ////////////////////////////////////////
class MyObject
{
    public string Text { get; set; } = null!;
    public int Value { get; set; }
}

class MyProgram
{
    public static void GetObject(out MyObject myObject) // MyObject*& myObject
    {
        myObject = new MyObject()
        {
            Text = "From out",
            Value = 42 + 1
        };
    }

    public static void PassReadonly(in MyObject myObject) // const MyObject*& myObject
    {
        myObject.Text = "123";
    }
    
    public static void ChangeObject(ref MyObject myObject) // MyObject*& myObject
    {
        // myObject.Text = "Changed!";
        // myObject.Value = 42;

        myObject = new MyObject()
        {
            Text = "Changed!",
            Value = 42
        };
    }
}

class Storage
{
    private List<IMovable> _items;

    public Storage()
    {
        _items = new();
    }
    
    public void Add(IMovable movable)
    {
        _items.Add(movable);
    }
}

interface IMovable
{
    int Speed { get; set; }

    void Move()
    {
        Console.WriteLine("default move");
    }

    static void Foo()
    {
        
    }

    static List<int> Values { get; } = new List<int>();
}

interface IFlyable
{
    int Acceleration { get; }
    void Fly();
}

abstract class Animal
{
    public abstract void Voice();
}

enum Color
{
    Red,
    Green,
    Blue
}

class Cat : Animal, IMovable
{
    public Color Color { get; set; }
    public override void Voice()
    {
        Console.WriteLine("meow-meow");
    }

    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Cat is moving");
    }
}

class Car : IMovable // Car implements IMoveable
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bird : Animal, IMovable, IFlyable
{
    private int _speed;

    public int Speed
    {
        get => _speed;
        set => _speed = value < 0 ? 1 : value;
    }

    public Bird()
    {
        Acceleration = 0;
    }
    
    public void Move()
    {
        Console.WriteLine("Bird is moving");
    }

    public int Acceleration { get; set; }

    public void Fly()
    {
        Acceleration += 1;
        Console.WriteLine("Bird is flying");
    }

    public override void Voice()
    {
        Console.WriteLine("chirik-chirik");
    }
}

interface IA
{
    List<object> ToList();
}

interface IB
{
    List<object> ToList();
}

class MyClass : IA, IB
{
    public MyClass() {}

    public List<object> ToList()
    {
        Console.WriteLine("MyClass.ToList");
        
        return [1, 2, 3];
    }
    
    List<object> IA.ToList()
    {
        Console.WriteLine("IA.ToList");
        
        return [10, 20, 30];
    }

    List<object> IB.ToList()
    {
        Console.WriteLine("IB.ToList");
        
        return [40, 50, "bla-bla-bla"];
    }
}


interface ITestInterface
{
    void Foo()
    {
        Console.WriteLine("Default Foo");
    }
}

class TestClass1 : ITestInterface
{
    public TestClass1()
    {
        
    }

    public void Foo()
    {
        Console.WriteLine("TestClass1 Foo");
    }
}

class TestClass2 : ITestInterface
{
    public TestClass2()
    {
        
    }
}