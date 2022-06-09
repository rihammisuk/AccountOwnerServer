using AutoMapper;
using Entities.Models;
using Entities.Models.DataTransferObjects;

namespace AccountOwnerServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
        }
    }
}
