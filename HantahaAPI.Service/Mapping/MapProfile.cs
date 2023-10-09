using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model;
using System.Security.Claims;

namespace HantahaAPI.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //reverse map iki classında birbirine dönüşebilmesini sağlıyor
            CreateMap<UserUpdateDto, User>()
                .ReverseMap();

            CreateMap<UserCreateDto, User>()
                .ReverseMap();

            //CreateMap<UserListDto, User>()
            //	.ReverseMap()
            //	.ForMember(d => d.Fullname, d => d.MapFrom(x => string.Format("{0} {1}", x.Firstname, x.Lastname)))
            //	.ForMember(d => d.Country, d => d.MapFrom(x => x.Country.Name));

            CreateMap<Claim, AuthenticatedUserDto>();
        }
    }
}

