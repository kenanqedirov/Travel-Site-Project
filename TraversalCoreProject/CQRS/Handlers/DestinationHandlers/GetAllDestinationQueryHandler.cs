using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProject.CQRS.Queries.DestinationQueries;
using TraversalCoreProject.CQRS.Results.DestinationResults;

namespace TraversalCoreProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;
        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.DestinationID,
                Capacity = x.Capacity,
                City = x.City,
                Price = x.Price,
                DayNight = x.DayNight
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
