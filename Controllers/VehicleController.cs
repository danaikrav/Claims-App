using Claims_App.Interfaces;
using Claims_App.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Claims_App.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Vehicles>))]
        public IActionResult GetVehicle()
        {
            var vehicles = _vehicleRepository.GetVehicles();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(vehicles);
        }

    }
}
