using cw9.Service;
using Microsoft.AspNetCore.Mvc;

namespace cw9.Controller;

[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase {
    private readonly ITripService _tripService;

    public TripsController(ITripService tripService) {
        _tripService = tripService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken, int page = 1, int pageSize = 10) {
        return Ok(await _tripService.GetTrips(page, pageSize, cancellationToken));
    }
}