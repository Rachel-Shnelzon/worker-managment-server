using Microsoft.EntityFrameworkCore;
using Server.Core.Entities;
using Server.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data.Repositories
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DataContext _context;
        public WorkerRepository(DataContext context)
        {
                _context = context;
        }

        public async Task<IEnumerable<Worker>> GetListAsync()
        {
            return _context.Workers.ToList().FindAll(w => w.IsActive == true);
        }
        public async Task<Worker> GetAsync(int id)
        {
            return await _context.Workers
             .Include(x => x.Roles)
                 .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Worker> AddWorkerAsync(Worker worker)
        {
            worker.IsActive=true;
            _context.Workers.Add(worker);
            await _context.SaveChangesAsync();
            return worker;
        }

        public async Task<Worker> UpdateAsync(int id, Worker worker)
        {
            var workerToUpdate = await GetAsync(id);
            //_context.Entry(workerToUpdate).CurrentValues.SetValues(worker);
            // Clear existing roles
            workerToUpdate.Roles.Clear();

            // Add updated roles
            foreach (var newRole in worker.Roles)
            {
                workerToUpdate.Roles.Add(newRole);
            }

            _context.Entry(workerToUpdate).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return workerToUpdate;
        }

        public async Task DeleteAsync(int id)
        {
            var worker1 = await GetAsync(id);
            //var worker2 = worker1;
            worker1.IsActive = false;
            //_context.Entry(worker2).State = EntityState.Modified;
            //_context.Entry(worker1).CurrentValues.SetValues(worker2);
            await _context.SaveChangesAsync();
        }

    }
}
