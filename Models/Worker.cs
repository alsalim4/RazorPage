using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStuff.Models
{
    public class Worker : Employee
    {
        public int Salary { get; set; }
        public string Position { get; set; }
    }
}
