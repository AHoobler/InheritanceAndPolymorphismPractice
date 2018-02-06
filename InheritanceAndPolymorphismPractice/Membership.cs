using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphismPractice
{
    public class Membership
    {
        // fields
        private int memberID;
        private bool isActive;

        //properties
        public int MemberID
        {
            get { return this.memberID; }
            set { this.memberID = value; }            
        }

        public bool IsActive
        {
            get { return this.IsActive; }
            set { this.isActive = value; }
        }

        //Constructors

        public Membership()
        {
            //DEFAULT
        }

        public Membership(int memberID, bool isActive)
        {
            this.memberID = memberID; //first memberID is field, then second is parameter
            this.isActive = isActive;
        }

        //methods
        public virtual void Activate()
        {
            if(isActive == false)
            {
                isActive = true; // changes the membership to active(true)
                Console.WriteLine("Your membership has been activated.");
            }
            else
            {
                Console.WriteLine("Your membership is already active.");
            }
        }



    }
}
