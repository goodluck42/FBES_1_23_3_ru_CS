using System.Reflection;
using System.Text.Json;
using Inheritance;


// User user = new User("qwerty", "123456789");
//
// Console.WriteLine(user);
//
// // serialization
// var json = JsonSerializer.Serialize(user, new JsonSerializerOptions()
// {
//     WriteIndented = true
// });
//
// Console.WriteLine(json);

// deserialization
// User? deserialized = JsonSerializer.Deserialize<User>(json);
//
// if (deserialized != null)
// {
//     Console.WriteLine(deserialized.Login);
//     Console.WriteLine(deserialized.Password);
// }



// Write to file
// File.WriteAllText("data.json", json);

// Read from file & Deserializa from json

var json = File.ReadAllText("data.json");

User? user = JsonSerializer.Deserialize<User>(json);

if (user != null)
{
    Console.WriteLine(user.Login);
    Console.WriteLine(user.Password);
}

Console.Read();

namespace Inheritance
{
    class User // Model (anemic model)
    {
        private string _login;

        public User(string login, string password)
        {
            _login = login;
            Password = password;
        }

        public string Login
        {
            get
            {
                Console.WriteLine("GET Login from User");
                return _login;
            }
            set
            {
                Console.WriteLine("SET Login from User");
                _login = value;
            }
        }

        public string Password { get; set; }
    }

    class Admin : User
    {
        private string _login;

        public Admin() : this(string.Empty, string.Empty)
        {

        }

        public Admin(string login, string password) : base(login, password)
        {

        }

        public new string Login
        {
            get
            {
                Console.WriteLine("GET Login from Admin");
                return _login;
            }
            set
            {
                Console.WriteLine("SET Login from Admin");
                _login = value;
            }
        }

        public bool CanChangePassword { get; set; }
    }

    class UserManager // a service
    {
        private readonly List<User> _users;

        public void AddUser(User user)
        {
            if (user.Login == string.Empty)
            {
                return;
            }
        }
    }
}