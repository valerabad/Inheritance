﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class ExpertDocumentWorker : ProDocumentWorker
    {

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
