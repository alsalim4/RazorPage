using eStuff.Data;
using eStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStuff.Repository
{
    public class AspirantsRepos
    {
        private readonly ApplicationDbContext _context;

        public AspirantsRepos(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreateAspirant()
        {
            Aspirant aspirant = new Aspirant();
            aspirant.Name = "Liza";
            aspirant.Male = false;
            aspirant.PhoneNumber = "77047301212";
            aspirant.LastName = "Clay";
            aspirant.Photopath = "123213123";
            _context.Aspirants.Add(aspirant);
            _context.SaveChanges();
        }
        public IEnumerable<Aspirant> GetAspirants()
        {
            return _context.Aspirants;
        }
    }
}
