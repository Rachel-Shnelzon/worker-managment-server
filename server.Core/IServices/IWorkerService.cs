using Server.Core.Entities;
using Server.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.IServices
{
    public interface IWorkerService
    {
       public Task<IEnumerable<Worker>> GetAllAsync();
       public Task<Worker> GetWorkerAsync(int id);
       public Task<Worker> AddWorkerAsync(Worker worker);
       public Task<Worker> UpdateWorkerAsync(int id, Worker worker);
       public Task DeleteWorkerAsync(int id);
    }
}

