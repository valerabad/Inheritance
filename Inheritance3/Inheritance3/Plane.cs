using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Plane : Vehicle
    {
        public int CountPassenger { get; set; }
        public int Hight { get; set; }

        public Plane(int x, int y, double price, double speed, int year,int countPassenger, int hight)
            : base(x,y,price,speed,year)
        {
            CountPassenger = countPassenger;
            Hight = hight;
        }

        public override void showInfo()
        {
            base.showInfo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Кол-во пассажиров: {0}\nВысота: {1}",CountPassenger, Hight);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
