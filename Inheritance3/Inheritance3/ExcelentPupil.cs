using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string lastname)
            : base(lastname) { } 

        public override void Read()
        {
            base.Read();
            Console.WriteLine("Быстро читает");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Отлично пишет");
        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Много учится");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Почти не отдыхает");
        }
    }
}
