using Template.Contracts.GenericEntity;
using Template.Contracts.Interfaces;
using Template.Contracts.Request;

namespace Template.Application.Api.Service
{
    public class VehicleService : IVehicleService
    {
        public IEnumerable<Vehicle> GetAll()
        {
            return new List<Vehicle>()
            {
                new Vehicle() {Model = "Camaro", Color="Yellow"},
                new Vehicle() {Model = "Mustang", Color="Black"}
            };
        }

        public Guid NewVehicle(VehicleRequest vehicle)
        {
            return Guid.NewGuid();
        }
    }
}
