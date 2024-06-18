using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Act2_U4
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual string MakeSound()
        {
            return "Animal sound";
        }
        public string ShowInfo()
        {
            return $"Nombre: {Name}, Edad: {Age}";
        }
    }
}
