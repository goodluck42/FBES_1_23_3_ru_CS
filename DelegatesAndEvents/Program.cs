using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using DelegatesAndEvents;


#region OperationDelegate

// Operation? op = Operations.Sum;
//
// int result = op(10, 5);
//
// Console.WriteLine(result);
//
// op = Operations.Mult;
//
// result = op(10, 3);
//
// Console.WriteLine(result);

//// old variant
// op = delegate(int a, int b)
// {
//     return a - b;
// };
// arrow - functions

//// new variant
// op = (num1, num2) =>
// {
//     return num1 - num2;
// };

//// new variant (simplified)
// op = (num1, num2) => num1 - num2;
//
// result = op(999, 9);
//
// Console.WriteLine(result);

#endregion

#region LambdaTests

// SomeAction action = null; //message => Console.WriteLine(message);
// UselessAction uselessAction = () => Console.WriteLine("I'm a useless action");
//
// action?.Invoke("Helloy");

#endregion

#region DelegateList

// List<Operation> operations = new List<Operation>();
//
// operations.Add(Operations.Sum);
// operations.Add(Operations.Mult);
//
// foreach (var operation in operations)
// {
//     Console.WriteLine(operation(10, 5));
// }

#endregion

// Operation calcOp = Operations.Sum;
//
// calcOp += Operations.Mult;
//
// Console.WriteLine(calcOp?.Invoke(10, 5));

// Action
// Func
// Predicate

#region BuiltInDelegates

Action action = () => { };
Action<string> action2 = value => { };
Action<string, int> action3 = (value, a) => { };
Action<string, int, double> action4 = (value, a, b) => { };

Func<int> func = () => 42;
Func<int, string> func2 = value => value.ToString();
Func<int, int, string> func3 = (a, b) => (a + b).ToString();

Predicate<string> predicate = value => value.Contains(' ');


List<int> values = [1, 2, 3, 4, 5];

int res = values.Find(x => x % 2 != 0);

Console.WriteLine(res);

///// Find implementation
// foreach (var value in values)
// {
//     if (oddPredicate(value))
//     {
//         Console.WriteLine(value);
//         
//         break;
//     }
// }


#endregion

#region EventsTest1

// var user = new User();
//
// user.AfterPasswordChanged += targetUser =>
// {
//     Console.Clear();
//     Console.WriteLine(targetUser.Login);
//     Console.WriteLine(targetUser.Password);
// };
//
// user.Login = "testlogin";
// user.Password = "qwerty";
#endregion
var observable = new ObservableCollection<int>();

observable.CollectionChanged += (sender, args) =>
{
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
        foreach (var item in args.NewItems!)
        {
            Console.WriteLine($"added {item}");
        }
    }

    if (args.Action == NotifyCollectionChangedAction.Remove)
    {
        foreach (var item in args.OldItems!)
        {
            Console.WriteLine($"removed {item}");
        }
    }
};

observable.Add(10);
observable.Add(20);
observable.Add(30);
observable.Add(42);


observable.RemoveAt(1);
observable.RemoveAt(1);

static class UserValidator
{
    public static bool IsValid(User user)
    {
        // ...
        return true;
    }
}

class UserDb
{
    public void Add(User user)
    {
        if (UserValidator.IsValid(user))
        {
            // _users.Add(user);
        }
    }
}

class User
{
    private string _password;
    public event Action<User>? BeforePasswordChanged;
    public event Action<User>? AfterPasswordChanged;

    public User()
    {
        Login = string.Empty;
        _password = string.Empty;
    }
    
    public string Login { get; set; }

    public string Password
    {
        get => _password;
        set
        {
            BeforePasswordChanged?.Invoke(this);
            
            _password = value;

            AfterPasswordChanged?.Invoke(this);
        }
    }
}




namespace DelegatesAndEvents
{
    public delegate int Operation(int a, int b); // typedef

    public delegate void SomeAction(string message);

    public delegate void UselessAction();

    public static class Operations
    {
        public static int Sum(int a, int b)
        {
            Console.WriteLine("Operations.Sum");

            return a + b;
        }

        public static int Mult(int a, int b)
        {
            Console.WriteLine("Operations.Mult");
            return a * b;
        }
    }
}