using AutoMapper;
using Core.Dtos;
using Core.Models;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>();
            CreateMap<Post, PostDto>();
        }
    }
}