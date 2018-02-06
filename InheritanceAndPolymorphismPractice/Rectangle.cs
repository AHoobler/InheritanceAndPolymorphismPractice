using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Rectangle : Shape
    { 
        //derived class. A dervied class does not inherit the constuctors of the base class
        // the constructors of the base class can be access using the "base" keyword
            private double area;

            public double Area
            {
                get { return this.area; }
                set { this.area = value; }
            }

            public Rectangle(double area)
            {
                this.area = area;
            }
        
    }
}
