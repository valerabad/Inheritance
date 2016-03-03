using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int task;
                Console.WriteLine("Enter task 1-4");
                int.TryParse(Console.ReadLine(), out task);
                switch (task)
                { 
                    case 1:
                        Printer p;
                        p = new Printer();
                        p.Print("test message");

                        p = new JetPrinter();
                        ((JetPrinter)p).Print("test message");
                        p = new InkPrinter();

                        ((InkPrinter)p).Print("test message");
                        p = new LaserPrinter();
                        ((LaserPrinter)p).Print("test message");
                    break;

                    case 2:
                        Pupil badPupil = new BadPupil("Иванов");
                        Pupil goodPupil = new GoodPupil("Сидоров");
                        Pupil exelentPupil = new ExcelentPupil("Петров");
                        Pupil testPupil = new GoodPupil("Бадица");

                        Classroom classroom = new Classroom(badPupil, goodPupil, exelentPupil, testPupil);
                        classroom.showInfo();
                    break;

                    case 3:
                        Vehicle plane = new Plane(12,34,200,500,1999,200,11000);                    
                        Vehicle ship = new Ship(33,44,100,80,1980,530,"Ротертадам");
                        Vehicle car = new Car(88,99,150,175,2001);
                        plane.showInfo();                    
                        ship.showInfo();
                        car.showInfo();                       
                    break;

                    case 4:
                        Console.WriteLine("Введите 1-без ключа, 2- PRO или 3-EXP ");
                        byte key;
                        byte.TryParse(Console.ReadLine(), out key);
                        switch (key)
                        {
                            case 1:
                                DocumentWorker freeVersion = new DocumentWorker();
                                freeVersion.OpenDocument();
                                freeVersion.EditDocument();
                                freeVersion.SaveDocument();                              
                                break;
                            case 2:
                                DocumentWorker pro = new ProDocumentWorker();
                                ((DocumentWorker)pro).OpenDocument();
                                ((DocumentWorker)pro).EditDocument();
                                ((DocumentWorker)pro).SaveDocument();
                                break;
                            case 3:
                                DocumentWorker exp = new ExpertDocumentWorker();
                                ((DocumentWorker)exp).OpenDocument();
                                ((DocumentWorker)exp).EditDocument();
                                ((DocumentWorker)exp).SaveDocument();
                                break;
                            default:

                                break;
                        }

                    break;

                }
                
            }          
            Console.ReadKey();
        }
    }
}

