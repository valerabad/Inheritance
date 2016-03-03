using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Classroom
    {
        List<Pupil> listPupils = new List<Pupil>();
        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            listPupils.Add(pupil1);
            listPupils.Add(pupil2);
            listPupils.Add(pupil3);
            listPupils.Add(pupil4);            
        }

        public Classroom(Pupil pupil1, Pupil pupil2)
        {
            listPupils.Add(pupil1);
            listPupils.Add(pupil2);
        }

        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            listPupils.Add(pupil1);
            listPupils.Add(pupil2);
            listPupils.Add(pupil3);
        }

        public void showInfo()
        {
            foreach (Pupil p in listPupils)
            {
                //Console.WriteLine(p.lastName);
                //Console.WriteLine( ((GoodPupil)p).lastName );
                Console.WriteLine(p.ToString());
                p.Read();
                p.Write();
                p.Study();
                p.Relax();
                Console.WriteLine();
            }
        }
    }
}


