using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Act2_U4
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog(string name, int age, string race) : base(name, age)
        {
            Race = race;
        }

        public override string MakeSound()
        {
            return "Guau";
        }

        public string GetCompleteInformation()
        {
            return base.ShowInfo() + $", Race: {Race}";
        }
    }
}
