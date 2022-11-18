using Claims_App.Models;

namespace Claims_App.Interfaces
{
    public interface IVehicleRepository
    {
        ICollection<Vehicles> GetVehicles();

        bool CreateVehicle(Vehicles vehicle);
        bool Save();
    }
}
