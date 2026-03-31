using System;

namespace Skills;

public class Member
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }

    public Member(string name, int age, string role)
    {
        Name = name;
        Age = age;
        Role = role;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Role: {Role}");
    }
}
