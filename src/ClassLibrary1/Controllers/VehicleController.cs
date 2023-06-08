using Microsoft.AspNetCore.Mvc;
using Template.Contracts.Interfaces;
using Template.Contracts.Request;

namespace Contract.WebApi.Controllers
{
    [ApiController]
    [Route("vehicles")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        [HttpGet]
        public IActionResult Vehicle()
        {
            var newVehicle = _vehicleService.NewVehicle(new VehicleRequest { Model = "Camaro", Color = "Yellow", Identification = "JXJ-1213" });
            return Ok(newVehicle);
        }
    }
}
