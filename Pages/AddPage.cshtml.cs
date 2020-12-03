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
    public class AddPageModel : PageModel
    {
        private readonly WorkerRepos _db;

        public AddPageModel(WorkerRepos db)
        {
            _db = db;
        }
        public string Name { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public string Position { get; set; }
        [BindProperty]
        public int DaysInCompany { get; set; }
        [BindProperty]
        public int Salary { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            //if (Name != null && LastName != null)
            //{
                Worker worker=new Worker();
                worker.Name = Name;
                worker.LastName = LastName;
                worker.PhoneNumber = PhoneNumber;
                worker.DaysInCompany = DaysInCompany;
                worker.Salary = Salary;
                worker.Male = true;
                worker.HirerName = "sad";
                worker.Position = Position;
                _db.AddWorker(worker);
                return RedirectToPage("/ManagePage");
            
        }
    }
}
