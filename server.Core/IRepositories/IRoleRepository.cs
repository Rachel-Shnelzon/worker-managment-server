

using Server.Core.Entities;

namespace server.Core.IRepositories
{
    public interface IRoleRepository
    {

        public Task<Role> PostAsync(Role role);
               
        public Task<IEnumerable<Role>> GetAllAsync();
               
        public Task<Role> GetAsync(int id);
               
        public Task DeleteAsync(int id);
    }
}