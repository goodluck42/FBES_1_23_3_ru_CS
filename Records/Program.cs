using System.IO;
using System.Text;

// var obj = new User("my_login", "my_password");
//
// obj.CreationTime = DateTime.Now;
//
// var objCopy = obj with
// {
//     Login = "super_login"
// };
//
// Console.WriteLine(obj);
// Console.WriteLine(objCopy);
//
// if (obj == objCopy)
// {
//     Console.WriteLine("Equals");
// }
// else
// {
//     Console.WriteLine("Not equals");
// }
//
// record User(string Login, string Password) // primary constructor
// {
//     public DateTime CreationTime { get; set; }
// }

//

//// Binary write
// {
//     using var fileStream = new FileStream(
//         @"data.txt",
//         FileMode.OpenOrCreate,
//         FileAccess.Write);
//
//     var message = Console.ReadLine()!;
//     var messageBytes = Encoding.UTF8.GetBytes(message);
//
//     fileStream.Write(messageBytes);
//     fileStream.Flush();
// }


//// Binary read
// {
//     using var fileStream = new FileStream(
//         @"data.txt",
//         FileMode.Open,
//         FileAccess.Read);
//
//     byte[] buffer = new byte[256];
//     int read = fileStream.Read(buffer, 0, buffer.Length);
//
//     Console.WriteLine($"Read: {read}");
//
//     var message = Encoding.UTF8.GetString(buffer);
//
//     Console.WriteLine($"Message: {message}");
// }


//// BinaryReader
// {
//     using var fileStream = new FileStream(
//         @"data.txt",
//         FileMode.Open,
//         FileAccess.Read);
//
//     using var binaryReader = new BinaryReader(fileStream);
//
//     // ...
//
// }


//// BinaryWriter
// {
//     using var fileStream = new FileStream(
//         @"data.txt",
//         FileMode.OpenOrCreate,
//         FileAccess.Write);
//
//     using var binaryWriter = new BinaryWriter(fileStream);
//
//     // ...
// }



//// StreamReader & StreamWriter

// using var streamWriter = new StreamWriter("names.txt");
// string[] names = ["Johny", "Joe", "Jack", "Jamal"];
//
// foreach (var name in names)
// {
//     streamWriter.WriteLine($"name: {name}");
// }


using var streamReader = new StreamReader("names.txt");

while (!streamReader.EndOfStream)
{
    var line = streamReader.ReadLine();
    
    Console.WriteLine(line);
}



var person = new Person
{
    FirstName = "Jamal",
    LastName = "TheBlackOne",
    Age = 42
};

class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Age { get; set; }
}