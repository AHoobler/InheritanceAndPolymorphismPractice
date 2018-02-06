using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class DeathEater : Wizard
    {
        //fields 
        private bool hasDarkMark;

        //Properties
        public bool HasDarkMark
        {
            get { return this.hasDarkMark; }
            set { this.hasDarkMark = value; }
        }

        //Constructor
        public DeathEater() : base(false)
        {

        }

        //Methods
        public override void MakeMagic()
        {
            Console.WriteLine("Crucio!");
        }
    }
}