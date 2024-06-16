using cw9.Models;

namespace cw9.Repositories;

public interface ITripRepository {
    Task<IEnumerable<Trip>> GetTrips(int page, int pageSize, CancellationToken cancellationToken);
}