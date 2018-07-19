using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        var miguel = new Person("Miguel", "de Icaza");
        int length = GetLengthOfMiddleName(miguel);
        WriteLine(length);
    }

    static int GetLengthOfMiddleName(Person p)
    {
        if (p.MiddleName == null)
        {
            return 0;
        }

        return p.MiddleName.Length;
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Person(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}
