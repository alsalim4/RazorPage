using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eStuff.Models;
using eStuff.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStuff.Pages
{
    public class AspirantPageModel : PageModel
    {
        private readonly AspirantsRepos _db;

        public AspirantPageModel(AspirantsRepos db)
        {
            _db = db;
        }
        public IEnumerable<Aspirant> Aspirants { get; set; }
        public void OnGet()
        {
            
            Aspirants=_db.GetAspirants();
        }
    }
}
