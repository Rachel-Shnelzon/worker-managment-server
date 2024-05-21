using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Core.DTOs
{
    public class WorkerDTO
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartWorkDate { get; set; }
    }
}
