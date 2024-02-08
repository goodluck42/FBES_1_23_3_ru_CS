using System.Threading.Channels;

// int[] arr = { 10, 20, 30 };
// int[] arr2 = new int[] { 10, 20, 30 };
// int[] arr3 = new int[4] { 10, 20, 30, 40};
// int[] arr4 = new int[3] { default, default, default };
//
// Console.WriteLine(arr4[0]);
// Console.WriteLine(arr4[1]);
//
// string?[]? names = new string[3] { null, null, null };
//
// Console.WriteLine(names[0] == null);
// Console.WriteLine(names[1] == null);
// Console.WriteLine(names[2] == null);

///////////////////////////////
// string? name = default;
// int age = default;
//
// Console.WriteLine(name == null);
// Console.WriteLine(age == 0);


int[,] mdArr = new int[2, 3]
{
  // 0   1   2
    {10, 20, 30}, // 0
    {40, 50, 60}  // 1
};
// interpolation
// Console.WriteLine($"mdArr[0][1]: {mdArr[0, 1]}");
//
// Console.WriteLine(mdArr.Rank);
// Console.WriteLine($"Lower: {mdArr.GetLowerBound(1)}");
// Console.WriteLine($"Upper: {mdArr.GetUpperBound(1)}");
//
// for (int i = 0; i <= mdArr.GetUpperBound(0); i++)
// {
//     for (int j = 0; j <= mdArr.GetUpperBound(1); j++)
//     {
//         Console.WriteLine(mdArr[i, j]);
//     }
// }

// jagged arrays

// int[][] arr = new int[3][]
// {
//     new int[3] { 10, 20, 30 },
//     new int[2] { 10, 20 },
//     new int[1] { 10 },
// };
//
// arr[0] = new[] { 10, 20, 30 };
// arr[1] = new[] { 10, 20 };
// arr[2] = new[] { 10 };

// for (int i = 0; i < arr.Length; i++)
// {
//     for (int j = 0; j < arr[i].Length; j++)
//     {
//         Console.WriteLine(arr[i][j]);
//     }
// }
/////////////////////////////
// int[] arr = { 10, 20, 30, 40 };
//
// int result = Array.Find(arr, x =>
// {
//     return x == 20;
// });
//
// Console.WriteLine(result);
//
//
// bool exists = Array.Exists(arr, x =>
// {
//     return x == 20;
// });
//
// Console.WriteLine(exists);
//
// int[] newArr = Array.FindAll(arr, x =>
// {
//     return x > 10;
// });
//
// for (int i = 0; i < newArr.Length; i++)
// {
//     Console.WriteLine($"newArr[i]: {newArr[i]}");
// }
//
// string s = "Hello C#";
//
// s = s.Replace("C#", "C++");
//
// Console.WriteLine(s);


// string langs = "C C++ C#";
//
// string[] langsArr = langs.Split(' ');
//
// foreach (string lang in langsArr)
// {
//     Console.WriteLine(lang);
// }

// string.Join(langs, ' ');

// char

// Console.WriteLine(string.Format("{0}, {1}, {2}", "C", "C++", "C#"));
// Console.WriteLine($"{"C"}, {"C++"}, {"C#"}");


string s1 = "hello";

s1 += 65;

Console.WriteLine(s1);

string input = Console.ReadLine()!;

switch (input)
{
    case "a":
    case "A":
        Console.WriteLine("input A");
        break;
    case "B":
        Console.WriteLine("input B");
        break;
    case "C":
        Console.WriteLine("input C");
        goto case "B";
}




