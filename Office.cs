using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class Office:Asset
    {  
        public string Name { get; set; }
        public Office(string name)
        {
            Name = name;
        }
    }
}
