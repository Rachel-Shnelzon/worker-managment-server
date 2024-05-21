using server.Core.IRepositories;
using Server.Core.Entities;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Data.Repositories
{
    public class RoleRepository: IRoleRepository
    {
        private readonly DataContext _context;
        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Role> PostAsync(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }


        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return _context.Roles.ToList().FindAll(r=> r.Status==true);
        }

        public async Task<Role> GetAsync(int id)
        {
            return _context.Roles.ToList().Find(r=> r.Id==id);
        }

        public async Task DeleteAsync(int id)
        {
            var role1 = await GetAsync(id);
            var role2 = await GetAsync(id);
            role2.Status = false;
            _context.Entry(role1).CurrentValues.SetValues(role2);
            await _context.SaveChangesAsync();
        }
    }
}
