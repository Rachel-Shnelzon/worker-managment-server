using server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public bool IsActive { get; set; }
        public List<WorkerRole> Roles { get; set; } 

        public enum GenderEnum
        {
            Male = 1,
            Female = 2
        }
    }
}
