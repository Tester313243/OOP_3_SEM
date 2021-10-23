﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Owner
    {
        readonly int id;
        string name;
        string company;
        public Owner(int Id, string Name, string Company)
        {
            this.id = Id;
            this.name = Name;
            this.company = Company;
        }
        public void printInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nCompany: {2}", id, name, company);
        }
    }
}
