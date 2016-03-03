using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string lastname)
            : base(lastname) { } 

        public override void Read()
        {
            base.Read();
            Console.WriteLine("Нормально читает");
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("Пока пишет с ошибками");
        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Часто занимается");
        }

        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Иногда отдыхает");
        }
    }
}
