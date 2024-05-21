using AutoMapper;
using Server.API.Models;
using server.Core.Entities;
using Server.Core.Entities;
using server.Api.Models;

namespace server.Api.Mapping
{
    public class PostModelMappingProfile : Profile
    {
        public PostModelMappingProfile()
        {
            CreateMap<WorkerPostModel, Worker>();
            //CreateMap<WorkerRolePostModel, WorkerRole>();
            CreateMap<RolePostModel, Role>();
        }
    }
}
