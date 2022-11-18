using Claims_App.Data;
using Claims_App.Interfaces;
using Claims_App.Models;

namespace Claims_App.Repository
{
    public class VehicleRepo: IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepo(DataContext context) {
            _context = context;
        }

        public ICollection<Vehicles> GetVehicles()
        {
            return _context.Vehicles.OrderBy(v => v.Id).ToList();
        }

        public bool CreateVehicle(Vehicles vehicle)
        {
            // Change Tracker
            //CONNECTED VS DISCONNECT
            // EntityState.Added
            //
            _context.Add(vehicle);
            Save();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
