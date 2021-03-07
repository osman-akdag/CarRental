using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.AutoMapper.Profiles
{
    public class ColorProfile : Profile
    {
        public ColorProfile()
        {
            CreateMap<ColorAddDto,Color>();
            CreateMap<ColorUpdateDto, Color>();
        }
    }
}
