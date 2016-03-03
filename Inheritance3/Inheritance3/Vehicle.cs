using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Vehicle
    {
        public double X { get; set;}
        public double Y { get; set;}

        public double Price { get; set; }
        public double Speed { get; set; }
        int year;
        public int Year
        {
            get { return year; }
            set 
            {
                if (value >= 1800)
                    year = value;
                else value = 0;
            }
        }

        public Vehicle(int x, int y, double price, double speed, int year)
        {
            X = x; Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }

        virtual public void showInfo()
        {
            Console.WriteLine("Координаты: ({0};{1})\nЦена: {2}\nСкорость: {3} км/ч\nГод выпуска: {4}", X,Y,Price,Speed,Year);
        }
    }
}
