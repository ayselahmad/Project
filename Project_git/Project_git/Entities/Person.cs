using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_git.Entities;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{Name} {Surname}");
    }
}
