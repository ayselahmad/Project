using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_git.Entities;

public class Developer : Person
{
    public Developer(string name, string surname) : base(name, surname)
    {
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
    }
}
