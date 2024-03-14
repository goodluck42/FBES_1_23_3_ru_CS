//// ---- Какие есть виды массивов?
//// ---- string vs StringBuilder?
//// ---- field vs auto property?
//// ---- Чем отличается auto property от property?
//// ---- Что такое backing field?
//// ---- Разница между set и init
//// ---- Ключевое слово required
//// ---- ValueType vs ReferenceType
//// ---- class vs struct
//// ---- access modifiers
//// ---- nullable vs non nullable, default keyword 
//// ---- Делегирующий конструктор
//// ---- namespaces
//// ---- global using, using static
//// ---- top level statements
//// ---- partial keyword
//// ---- extension methods
//// ---- LINQ and deferred execution
//// ---- interface vs abstract class
//// ---- records
//// ---- generics
//// ---- generics constraints
//// ---- boxing and unboxing
//// ---- delegates and events
//// ---- GC (LOH, SOH) > 85000
//// ---- .NET Framework vs .NET Core vs .NET
//// ---- .NET Languages
//// ---- FCL/BCL
//// ---- CTS, CLS
//// ---- CLR
//// ---- why IL Code?
//// ---- metadata vs manifest

global using System.Text.Json;
using System.Net.Mail;
using MailKit.Net.Smtp;

using static System.Math;

System.Net.Mail.SmtpClient smtpClient1 = new System.Net.Mail.SmtpClient();
MailKit.Net.Smtp.SmtpClient smtpClient2 = new MailKit.Net.Smtp.SmtpClient();

// int[] arr = new int[3];
// int[,] mdArr = new int[5, 3];
//
// mdArr[0, 2] = 5;
//
// int[][] jagged = new int[5][];
//
// jagged[0] = new int[3] { 10, 20, 30 };
// jagged[1] = new int[2] { 10, 20 };

string str = "Helloy";

StringExtensions.SomeOperation(str);
str.SomeOperation();

var list = new List<int>();

StringExtensions.SomeOperation(list);

{
    var user1 = new User();
    var user2 = user1 with { };

    if (user1 == user2)
    {
        
    }
}

public static class StringExtensions
{
    public static void SomeOperation(this string source)
    {
        
    }
    public static void SomeOperation(List<int> list)
    {
        
    }
    
    
}

public delegate void MyDelegate();

record User
{
    public MyDelegate? Login { get; set; }
}

interface IMyCollection<T>
    where T : IComparable<T>, new()
{
    
}