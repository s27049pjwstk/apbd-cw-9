using cw9.Repositories;

namespace cw9.Service;

public class TripService(ITripRepository tripRepository) : ITripService {
    public async Task<object?> GetTrips(int page, int pageSize, CancellationToken cancellationToken) {
        return await tripRepository.GetTrips(page, pageSize, cancellationToken);
    }
}