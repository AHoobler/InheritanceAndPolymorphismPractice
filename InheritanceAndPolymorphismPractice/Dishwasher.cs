using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Dishwasher : Appliance
    {
        //fields
        //invisible

        //properties
        public double DecibelLevel { get; set; }
        public bool HasHeatDry { get; set; }

        //Constructors
        public Dishwasher()
        {
            //default
        }

        public Dishwasher(double decibelLevel, bool hasHeatDry) //camelcase
        {
            DecibelLevel = decibelLevel; //Do not need this keyword because of case. Property is being set to each parameter
            HasHeatDry = hasHeatDry;
        }

        //methods

        public override void Work()
        {
            Console.WriteLine("I was your dishes.");
            Console.WriteLine("wash wash wash");
        }


    }
}
