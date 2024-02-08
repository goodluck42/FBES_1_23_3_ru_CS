namespace Classes;

class UserDb
{
    static UserDb()
    {
        // 1. Object creation
        // 2. Static field/property/method access
        SomeData = 42;
    }
    
    private static readonly int SomeData; 
    private readonly List<User> _users;
    //public static readonly int MaxCapacity = 42;
    public const int MaxCapacity = 42;
    // const = constexpr
    // static = static
    public UserDb()
    {
        _users = new List<User>(MaxCapacity);
    }

    public void AddUser(User user) // Create
    {
        if (user.Name != string.Empty)
        {
            _users.Add(user);
        }

    }

    public void Update(User oldUser, User newUser) // Update
    {
        var index = _users.IndexOf(oldUser);

        if (index != -1)
        {
            _users[index] = newUser;
        }
    }

    public bool Remove(User user) // Delete
    {
        return _users.Remove(user);
    }

    public User? GetUserByName(string name) // Read
    {
        // for (int i = 0; i < _users.Count; i++)
        // {
        //     if (_users[i].Name == name)
        //     {
        //         return _users[i];
        //     }
        // }


        foreach (User user in _users)
        {
            if (user.Name == name)
            {
                return user;
            }
        }
        
        //throw new InvalidOperationException("User not found!");
        return null;
    }

    public void Clear()
    {
        //_users = new List<User>();
    }

    // readonly property
    public int Count
    {
        get => _users.Count;
    }
}