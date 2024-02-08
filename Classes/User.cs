namespace Classes;

class User
{
    private int _age; // backingField
    public string? Name { get; set; } // auto property

    public User() : this(name: string.Empty, age: 42)
    {
        
    }

    public User(int age, string name)
    {
        _age = age;
        Name = name;
    }

    public int Age
    {
        get => _age;

        set
        {
            if (value >= 0)
            {
                _age = value;
            }
        }
    } // full property
}