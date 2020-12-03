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
    public class ManagePageModel : PageModel
    {
        private readonly WorkerRepos _db;
        public ManagePageModel(WorkerRepos db)
        {
            _db = db;
            
        }
        public IEnumerable<Worker> workerlist { get; set; }
        public void OnGet()
        {
            workerlist= _db.GetAllUserWorkers();
        }
    }
}
