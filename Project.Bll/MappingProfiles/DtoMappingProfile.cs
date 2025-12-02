using Project.Bll.Dtos;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace Project.Bll.MappingProfiles
{
    public class DtoMappingProfile:Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }

    }
}
