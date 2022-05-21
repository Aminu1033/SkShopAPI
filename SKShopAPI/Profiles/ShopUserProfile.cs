using AutoMapper;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Profiles
{
    public class ShopUserProfile : Profile
    {
        public ShopUserProfile()
        {
            CreateMap<UserForCreationDto, User>()
                .ForMember(destinationMember => destinationMember.UserName,
                    opt => opt.MapFrom(sourceMember => sourceMember.Email));

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.FullName,
                  opt => opt.MapFrom(srcMember => $"{srcMember.FirstName} {srcMember.LastName}"))
                .ForMember(dest => dest.UserName,
                    opt => opt.MapFrom(sourceMember => sourceMember.Email))
                .ForMember(dest => dest.NumberOfOrders,
                    opt => opt.MapFrom(sourceMember => sourceMember.Orders.Count));
        }        
    }
}
