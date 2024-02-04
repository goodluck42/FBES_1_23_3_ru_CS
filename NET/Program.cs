// Top level statements

Console.WriteLine("Hello, World!");
{
    object o = 1;
    
    bool s = true; // 1b
    byte b = 255; // 1b
    sbyte sb = 127; // 1b (-128 - 127)
    char c = '@'; // 2b
    short sh = 100; // 2b
    ushort ush = 100; // 2b
    int i = 100; // 4b
    uint ui = 100U; // 4b
    long l = 1000L; // 8b
    ulong ul = 1000UL; // 8b

    float f = 2.0f; // 4b
    double d = 2.133; // 8b
    decimal dc = 2.0M; // 16b

    string str = "Hello C#";
}

{
    // string str = true.ToString();
    // string value = "42";
    //
    //
    // // parse out
    // bool b = int.TryParse(value, out int v);
    //
    // if (b)
    // {
    //     Console.WriteLine(v * 2);
    // }
    // else
    // {
    //     Console.WriteLine("failcast");
    // }
    //
    // try
    // {
    //     int res = int.Parse(value);
    //
    //     Console.WriteLine(res);
    // }
    // catch (FormatException ex)
    // {
    //     Console.WriteLine(ex.Message); // ex.what();
    // }
    //
    // float c = Convert.ToSingle(value);
    // int f = (int)c;

    // nullable types
    int? x = null;
    string? input = Console.ReadLine();

    if (!string.IsNullOrEmpty(input))
    {
        x = int.Parse(input);

        Console.WriteLine(x * 2);
    } 
    
    do
    {
        
    } while (true);
    
    while (true)
    {
        
    }
    
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);   
    }
}
Console.WriteLine(0.1 + 0.2);
Console.WriteLine(0.1f + 0.2f);
Console.WriteLine(0.1m + 0.2m);

// char = Char
// byte = Byte
// sbyte = SByte
// short = Int16
// ushort = UInt16
// uint = UInt32
// int = Int32
// long = Int64
// ulong = UInt64

// float = Single
// double = Double
// decimal = Decimal

// Console.Read();