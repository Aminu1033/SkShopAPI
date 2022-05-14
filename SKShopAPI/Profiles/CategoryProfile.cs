using AutoMapper;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.NumberOfProducts,
                opt=>opt.MapFrom(sourceMember=> sourceMember.Products.Count())
                );

            CreateMap<CategoryForCreationDto, Category>();

            CreateMap<CategoryForUpdateDto, Category>();
        }
    }
}
