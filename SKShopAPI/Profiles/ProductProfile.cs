using AutoMapper;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest=>dest.CategoryName, 
                                opt=>opt.MapFrom(srcMember=>srcMember.Category.Name)); 
            
            CreateMap<ProductForCreationDto, Product>();

            CreateMap<ProductForUpdateDto, Product>();
            CreateMap<Product, ProductForUpdateDto>();
        }
    }
}
