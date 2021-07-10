using AutoMapper;
using HotelApi.Data;
using HotelApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Configurations
{
    public class InitAutoMapper: Profile
    {
        public InitAutoMapper()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();

            CreateMap<Country, CreateCountryDTO>().ReverseMap();

            CreateMap<Hotel, HotelDTO>().ReverseMap();

            CreateMap<Country, CreateHotelDTO>().ReverseMap();
        }
    }
}
