using Api.Model;
using System.Threading.Tasks;

namespace Api.Services.POIServices
{
    public interface IPOIService
    {
        Task<POIDto> GetPOI(double Longitude, double Latitude);

        Task<POIDto> SetPOI(POIDto poiDto); 
    }
}
