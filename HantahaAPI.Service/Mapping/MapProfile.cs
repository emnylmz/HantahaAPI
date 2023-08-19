using System;
using System.Security.Claims;
using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model;

namespace HantahaAPI.Service.Mapping
{
    public class MapProfile:Profile
	{
		public MapProfile()
		{
			//reverse map iki classında birbirine dönüşebilmesini sağlıyor
			CreateMap<UserDto,User>()
                .ReverseMap()
                .ForMember(d => d.FullName, d => d.MapFrom(x => string.Format("{0} {1}", x.Firstname, x.Lastname)));

			CreateMap<Claim, AuthenticatedUserDto>();
        }
	}
}

