using AutoMapper;

namespace Api.Model.MappingProfiles
{
    public class POIMapping : Profile
    {
        public POIMapping()
        {
            //TODO add country name 
            CreateMap<POI, POIDto>().ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City.Name))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.City.Country.Name));
           
        }
    }
}
