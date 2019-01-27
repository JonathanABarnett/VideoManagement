using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VideoManagement.Dto;
using VideoManagement.Models;

namespace VideoManagement.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>();
        }

    }
}