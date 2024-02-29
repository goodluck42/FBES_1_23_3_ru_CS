using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using LINQ.Headers;

var manualResetEvent = new ManualResetEvent(false);
// var list = new List<int>() { 10, 20, 30 };
// var stack = new Stack<int>();
// stack.Push(90);
// stack.Push(80);
// stack.Push(70);
//
// list.Print();
// stack.Print();

// take 6 skip 2
List<string> names = new List<string>()
{
    "John",
    "Jack",
    "Joe",
    "Nurlan",
    "Samir",
    "Ali",
    "Khanbaba",
    "Timur",
    "Jamal",
    //"shpion"
};

//// First
// try
// {
//     var query = names.First(x => x.StartsWith('L'));
//
//     Console.WriteLine(query);
// }
// catch (InvalidOperationException ex)
// {
//     Console.WriteLine("Not found!");
// }

/// FirstOrDefault
// {
//     var query = names.FirstOrDefault(x => x.EndsWith('x'));
//
//     Console.WriteLine(query);
//     
//     if (query == null)
//     {
//         Console.WriteLine("Not found!");
//     }
// }

//var result2 = Enumerable.Where(names, x => x.StartsWith('J'));

///// deffered execution
// var result = names.MyWhere(x => x.StartsWith('S'));
//
// Console.WriteLine("1");
//
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }
//
// names.Add("Samira");
//
// Console.WriteLine("2");
//
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }
//// Take
// var range = new Range(2, 5);
// var slice = names.Take(range);
//
// foreach (var value in slice)
// {
//     Console.WriteLine(value);
// }

// Skip
// var slice = names.Take(6).Skip(2);
//
// foreach (var value in slice)
// {
//     Console.WriteLine(value);
// }

// TakeWhile & SkipWhile

// var slice = names.TakeWhile(x => x.StartsWith('J'));
// var slice = names.SkipWhile(x => x.StartsWith('J'));
//
// foreach (var value in slice)
// {
//     Console.WriteLine(value);
// }

// 

// All, Any
// var isAllCapitalised = names.All(x => char.IsUpper(x[0]));
// var isAllCapitalised = names.Any(x => char.IsUpper(x[0]));
//
// Console.WriteLine(isAllCapitalised);


// Max, Min, Average
// var values = new int[3] { 10, 20, 30 };
// var result = values.Min();


// MaxBy, MinBy

// var users = new User[3]
// {
//     new User
//     {
//         Login = "123",
//         Id = 1
//     },
//     new User
//     {
//         Login = "456",
//         Id = 2
//     },
//     new User
//     {
//         Login = "789",
//         Id = 3
//     }
// };
// var maxId = users.MaxBy(x => x.Id);

// Count & TryGetNonEnumeratedCount
// names.TryGetNonEnumeratedCount()


// Concat

// var arr = new int[3] { 1, 2, 3 };
// var list = new List<int> { 4, 5, 6 };
//
// var result = arr.Concat(list);
//
// result.Print();


// Select
// var users = new User[3]
// {
//     new User
//     {
//         Login = "vadik_log",
//         Password = "my_vad",
//         Id = 1
//     },
//     new User
//     {
//         Login = "petya_hh",
//         Password = "petooh",
//         Id = 2
//     },
//     new User
//     {
//         Login = "slavik",
//         Password = "slave123",
//         Id = 3
//     }
// };
//
// var x = new
// {
//     Message = "Hello C#",
//     Code = 0
// };
//
// var result = users.Select(x => new
// {
//     Id = x.Id,
//     Login = x.Login
// });
//
// foreach (var user in result)
// {
//     //Console.WriteLine(user);
//     Console.WriteLine(user.Id);
//     Console.WriteLine(user.Login);
//     //Console.WriteLine(user.Password);
// }


/////// yield
// var result = Enumerate();
//
// var enumerator = result.GetEnumerator();
//
// enumerator.MoveNext();
// Console.WriteLine(enumerator.Current);
//
// enumerator.MoveNext();
// Console.WriteLine(enumerator.Current);
//
//
// IEnumerable<string> Enumerate()
// {
//     yield return "Vadik";
//     yield return "Petya";
//     yield return "Slavik";
// }


manualResetEvent.WaitOne();

var obj = new MyClass<string>();

class MyClass<T>
where T : notnull
{
    public MyClass()
    {
        T obj = new T();
    }
}

