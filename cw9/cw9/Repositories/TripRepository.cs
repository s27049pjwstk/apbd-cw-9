using cw9.Context;
using cw9.Models;
using Microsoft.EntityFrameworkCore;

namespace cw9.Repositories;

public class TripRepository(S27049Context _dbContext) : ITripRepository {
    public async Task<IEnumerable<Trip>> GetTrips(int page, int pageSize, CancellationToken cancellationToken) {
        var trips = await _dbContext.Trips.OrderBy(e => e.DateFrom).Skip((page - 1) * pageSize).Take(pageSize)
            .ToListAsync(cancellationToken);
        return trips;
        // return new {
        //     pageNum = page,
        //     pageSize = pageSize,
        //     allPages = _dbContext.Trips.Count(),
        //     trips = trips
        // }
        
    }
}