using System;
using System.Collections.Generic;
using System.Text;

namespace Assets_Management_System
{
    class Office
    {
        public string Name { get; set; }
        public int OfficeId { get; set; }
        
        public Office(string name)
        {
            Name = name;
        }
    }
}
