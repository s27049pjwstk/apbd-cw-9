namespace cw9.Service;

public interface ITripService {
    Task<object?> GetTrips(int page, int pageSize, CancellationToken cancellationToken);
}