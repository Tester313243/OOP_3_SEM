﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Printer 
    {
     public void IAmPrinting(Weapon weaponObject)
        {
            Console.WriteLine(weaponObject.ToString());  
        }
    }
}
