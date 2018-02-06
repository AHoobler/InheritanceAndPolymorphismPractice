using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Standard : Membership
    {
        //fields
        //invisible 
        
        //properties
        public int Cost { get; set; } //shorthand creates lowercase cost field. only works whe fields arent declared

        //constuctor
        public Standard()
        {
            //default
        }

        public Standard(int cost) //overloaded constructor
        {
            Cost = cost;
        }

        //methods
        public override void Activate()
        {
            if (IsActive == false) //Uppercase, accessing the property
            {
                IsActive = true; // changes the membership to active(true)
                Console.WriteLine("Your standard membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your standard membership is already active.");
            }
        }
    }
}
