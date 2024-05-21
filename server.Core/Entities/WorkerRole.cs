using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Core.Entities
{
    public class WorkerRole
    {
        public int WorkerId { get; set; }
        public int RoleId { get; set; }
        public bool IsManagerial { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
