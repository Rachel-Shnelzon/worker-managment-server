using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Core.IServices
{
    public interface IRoleService
    {
        public Task<IEnumerable<Role>> GetAllAsync();

        public Task<Role> GetRoleAsync(int id);

        public Task<Role> PostAsync(Role role);

        public Task DeleteRoleAsync(int id);

    }
}
