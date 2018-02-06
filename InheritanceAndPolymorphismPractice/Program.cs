using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizardOne = new Wizard(true);

            HogwartsStudent longbottom = new HogwartsStudent();

            DeathEater malfoy = new DeathEater();

            wizardOne.MakeMagic();
            longbottom.MakeMagic();
            malfoy.MakeMagic();
        }
    }
}
