using AutoMapper;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Profiles
{
    public class OderProfile : Profile
    {
        public OderProfile()
        {
            CreateMap<Order, OrderDto>();

            CreateMap<OrderForCreationDto, Order>(); 
        }
    }
}
