using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public abstract class Appliance // ABSTRACT
    {
        //field
        private bool isElectric;

        //properties
        public bool IsElectric
        {
            get { return this.isElectric; }
            set { this.isElectric = value; }
        }

        //constructors - NONE

        //methods
        public abstract void Work(); 
    }
}
