using eStuff.Data;
using eStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eStuff.Repository
{
    public class WorkerRepos
    {
        private readonly ApplicationDbContext _context;

        public WorkerRepos(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Worker> GetAllUserWorkers()
        {
            //_context.Workers.Where(x => x.HirerName.Contains(NameOfHirer));
            return _context.Workers;
        } 
        public Worker AddWorker(Worker newWorker)
        {
            _context.Workers.Add(newWorker);
            _context.SaveChanges();
            return newWorker;
        }
        public Worker DeleteWorker(int id)
        {
            Worker workerDelete = _context.Workers.FirstOrDefault(x => x.Id == id);
            if (workerDelete != null)
            {
                _context.Workers.Remove(workerDelete);
                _context.SaveChanges();
                return null;
            }
            return workerDelete;
        }
    }
}
