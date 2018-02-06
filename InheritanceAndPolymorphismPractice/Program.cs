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

            //cannot instantiate an appliance

            Microwave myMicrowave = new Microwave(1000, "Samsung");
            Dishwasher myDishwasher = new Dishwasher(0, true);

            myMicrowave.Work();
            myDishwasher.Work();








            //Standard gymMember1 = new Standard(100);

            //VIP gymMember2 = new VIP();

            //gymMember1.Activate();
            //gymMember2.Activate();



            //Wizard wizardOne = new Wizard(true);

            //HogwartsStudent longbottom = new HogwartsStudent();

            //DeathEater malfoy = new DeathEater();

            //wizardOne.MakeMagic();
            //longbottom.MakeMagic();
            //malfoy.MakeMagic();
        }
    }
}
