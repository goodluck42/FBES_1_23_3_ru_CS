global using System.Collections.Generic;
using Classes;

User user = new User();

user.Age = -42; // set

Console.WriteLine(user.Age); // get
Console.WriteLine(UserDb.MaxCapacity);

// CRUD
// C - Create
// R - Read
// U - Update
// D - Delete

class P { }