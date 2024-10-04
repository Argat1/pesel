using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel
{
    internal class Person
    {
        int Id;
        int age;
        string name;
        string surname;
        string gender;
        string pesel;

        Person(int id, int age, string name, string surname, string gender, string pesel)
        {
            Id = id;
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.pesel = pesel;
        }

        Person()
        {

        }
    }
}
