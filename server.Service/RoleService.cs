using server.Core.IRepositories;
using server.Core.IServices;
using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _IroleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _IroleRepository = roleRepository;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _IroleRepository.GetAllAsync();
        }

        public async Task<Role> GetRoleAsync(int id)
        {
            return await _IroleRepository.GetAsync(id);
        }
        public async Task<Role> PostAsync(Role role)
        {
            return await _IroleRepository.PostAsync(role);
        }

        public async Task DeleteRoleAsync(int id)
        {
            _IroleRepository.DeleteAsync(id);
        }



    }
}
