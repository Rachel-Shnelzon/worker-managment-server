using AutoMapper;
using server.Core.DTOs;
using server.Core.Entities;
using Server.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Worker, WorkerDTO>().ReverseMap();
            //CreateMap<WorkerRole, WorkerRoleDto>();
            CreateMap<Role, RoleDTO>()
         .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

        }
    }
}
