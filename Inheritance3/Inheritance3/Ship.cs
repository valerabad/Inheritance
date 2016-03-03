using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Ship : Vehicle
    {
        public int CountPassenger { get; set; }
        public string Port { get; set; }

        public Ship(int x, int y, double price, double speed, int year,int countPassenger, string port)
            : base(x,y,price,speed,year)
        {
            CountPassenger = countPassenger;
            Port = port;
        }

        public override void showInfo()
        {
            base.showInfo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Кол-во пассажиров: {0}\nПорт: {1}", CountPassenger, Port);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
