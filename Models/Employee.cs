using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStuff.Models
{
    public abstract class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Male { get; set; }
        public int DaysInCompany { get; set; }
        public string HirerName { get; set; }

    }
}
