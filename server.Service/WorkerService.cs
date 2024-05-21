using Server.Core.Entities;
using Server.Core.IRepositories;
using Server.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Service
{
    public class WorkerService:IWorkerService
    {
        private readonly IWorkerRepository _IworkerRepository;
        public WorkerService(IWorkerRepository IworkerRepository)
        {
                _IworkerRepository= IworkerRepository;
        }
        public async Task<IEnumerable<Worker>> GetAllAsync()
        {
            return await _IworkerRepository.GetListAsync();
        }

        public async Task<Worker> GetWorkerAsync(int id)
        {
            return await _IworkerRepository.GetAsync(id);
        }

        public async Task<Worker> AddWorkerAsync(Worker worker)
        {
            return await _IworkerRepository.AddWorkerAsync(worker);
        }

        public async Task<Worker> UpdateWorkerAsync(int id, Worker worker)
        {
            return await _IworkerRepository.UpdateAsync(id, worker);
        }

        public async Task DeleteWorkerAsync(int id)
        {
           await _IworkerRepository.DeleteAsync(id);
        }
    }
}
