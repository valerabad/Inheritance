using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Car : Vehicle
    {
        public Car(int x, int y, double price, double speed, int year)
            : base(x, y, price, speed, year) { }
        
    }
}
