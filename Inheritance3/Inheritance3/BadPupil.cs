using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class BadPupil : Pupil
    {
        public BadPupil(string lastname)
            : base(lastname) { }       

        public override void Read()
        {
            base.Read();
            Console.WriteLine("Не умеет читать");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Не умеет писать");
        }
        public override void  Study()
        {
 	         base.Study();
             Console.WriteLine("Мало учится");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Много отдыхает");
        }
        
    }
}
