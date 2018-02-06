using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class VIP : Membership
    {
        //fields
        //invisible

        //properties
        public bool IsSwanky { get; set; } //creating invisible field behind the scenes

        //constructors
        public VIP()
        {
            //default
        }

        public VIP(bool isSwanky)
        {
            this.IsActive = isSwanky; //different variables with the same name
        }

        //method
        public override void Activate()
        {
            IsSwanky = true; //becomes true when VIP is activated

            if (IsActive == false)
            {
                IsActive = true; // changes the membership to active(true)
                Console.WriteLine("You are now a big deal.");
            }
            else
            {
                Console.WriteLine("You are already a bog deal.");
            }
        }



    }
}
