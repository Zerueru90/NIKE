using Api.Model;
using Api.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.POIServices
{
    public class POIService : IPOIService
    {
        private readonly IMapper _mapper;
        private readonly IPOIRepository _POIRepository;
        public POIService(IPOIRepository POIRepository, IMapper mapper)
        {
            _POIRepository = POIRepository;
            _mapper = mapper;
        }
        public async Task<POIDto> GetPOI(double Longitude, double Latitude)
        {
            return _mapper.Map<POIDto>(await _POIRepository.Get(Longitude, Latitude));
        }
    }
}
