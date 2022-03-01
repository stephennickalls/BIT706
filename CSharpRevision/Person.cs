using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    class Person
    {

        private int id;
        private string name;
        private List<Car> myCars = new List<Car>();


        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        public List<Car> MyCars
        {
            get { return myCars; }
            set { myCars = value; }
        }
    }
}
