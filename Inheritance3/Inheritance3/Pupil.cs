using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Pupil
    {
        public string lastName {get; set;}
        public Pupil(string lastname)
        {
            this.lastName = lastName;
        }
        virtual public void Study() { }
        virtual public void Read()  { }
        virtual public void Write() { }
        virtual public void Relax() { }
    }
}
