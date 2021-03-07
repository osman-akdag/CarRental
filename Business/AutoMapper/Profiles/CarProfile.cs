using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.AutoMapper.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<CarAddDto, Car>();
            CreateMap<CarUpdateDto, Car>();
        }
    }
}
