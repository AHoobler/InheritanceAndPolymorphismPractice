using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class HogwartsStudent : Wizard
    {
        //fields
        private int yearInSchool;

        //Properties
        public int YearInSchool
        {
            get { return this.yearInSchool; }
            set { this.yearInSchool = value; }
        }

        //Constructors
        public HogwartsStudent()
        {
            //default constructor
        }

        public HogwartsStudent(int yearInSchool)
        {
            this.yearInSchool = yearInSchool;
            this.IsGood = true;
        }

        //Methods
        public int Study()
        {
            return yearInSchool++;
        }

        public override void MakeMagic() // use override in the derived classes to chage
        {
            base.MakeMagic(); //does everything in the wizard class, and also the overrride
            Console.WriteLine("Accio Book!");
        }

    }
}