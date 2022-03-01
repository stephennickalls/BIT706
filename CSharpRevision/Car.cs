using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    class Car
    {
        private string reg;
        private string make;
        private Person owner;

        public Car(string reg, string make)
        {
            this.reg = reg;
            this.make = make;
        }


        public Person Owner
        {
            get { return owner; }
            set { owner = value; }
        }


    }
}
