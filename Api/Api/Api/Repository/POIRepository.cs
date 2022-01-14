using Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class POIRepository : IPOIRepository
    {
        private readonly NIKEContext _context;
        public POIRepository(NIKEContext context)
        {
            _context = context;
        }

        public async Task<POI> Get(double Longitude, double Latitude)
        {
            return await _context.POI.AsNoTracking().Include(x => x.City).FirstOrDefaultAsync(POI => POI.Longitude == Longitude && POI.Latitude == Latitude);
        }
    }
}
