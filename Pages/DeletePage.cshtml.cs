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
    public class DeletePageModel : PageModel
    {
        private readonly WorkerRepos _db;

        public DeletePageModel(WorkerRepos db)
        {
            _db = db;
        }
        public Worker worker { get; set; }
        public IActionResult OnGet(int id)
        {
            worker = _db.DeleteWorker(id);
            if (worker == null)
                return RedirectToPage("/Error");
            return Page();
        }
    }
}
