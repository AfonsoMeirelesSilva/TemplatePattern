using Template.Contracts.GenericEntity;
using Template.Contracts.Request;

namespace Template.Contracts.Interfaces
{
    /// <summary>
    /// Interface for Vehicle, CRUD and so on
    /// </summary>
    public interface IVehicleService
    {
        public Guid NewVehicle(VehicleRequest vehicle);
        public IEnumerable<Vehicle> GetAll();
    }
}
