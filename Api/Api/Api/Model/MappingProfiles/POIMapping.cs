using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model.MappingProfiles
{
    public class POIMapping : Profile
    {
        public POIMapping()
        {
            //TODO add country name 
            CreateMap<POI, POIDto>().ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City.Name));
        }
    }
}
