using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.IRepositories
{
    public interface IWorkerRepository
    {
        public Task<IEnumerable<Worker>> GetListAsync();
        public Task<Worker> GetAsync(int id);
        public Task<Worker> AddWorkerAsync(Worker worker);
        public Task<Worker> UpdateAsync(int id, Worker worker);
        public Task DeleteAsync(int id);
    }
}
