using server.Core.Entities;
using Server.Core.Entities;
using static Server.Core.Entities.Worker;

namespace Server.API.Models
{
    public class WorkerPostModel
    {
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public List<WorkerRole> Roles { get; set; } = new List<WorkerRole>() { };
    }
}
