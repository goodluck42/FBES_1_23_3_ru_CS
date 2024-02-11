// See https://aka.ms/new-console-template for more information

// CRUD

// ArgumentException
// InvalidOperationException
// IndexOutOfRangeException
// ArgumentOutOfRangeException

// NullReferenceException;

Console.WriteLine(nameof(Account));

// throw new IndexOutOfRangeException();

// string a = "A";
//
// switch (a)
// {
//     case "A":
//         break;
//     case "B":
//         break;
//     default:
//         throw new ArgumentOutOfRangeException();
// }
//
// Console.WriteLine("Hello, World!");

// string? name = null;

// Console.WriteLine(name ?? "Name not set");

// int a = 2147483647;
// int value = int.Parse(Console.ReadLine()!);
//
// try
// {
//     Console.WriteLine(a + value);
// }
// catch (OverflowException ex)
// {
//     Console.WriteLine(ex.Message);
// }

var list = new List<int>() { 10, 20, 30 };

try
{
    int i = int.Parse(Console.ReadLine()!);

    Console.WriteLine(list[i]);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Incorrect index");

    throw;
}
catch (Exception ex) when (ex is FormatException or OverflowException)
{
    Console.WriteLine("Incorrect Data");
}
finally
{
    Console.WriteLine("Finally");
}


// var list = new List<int>();
//
// while (true)
// {
//     try
//     {
//         
//     }
//     catch
//     {
//
//     }
//     finally
//     {
//         break; // another stack frame
//     }
// }


