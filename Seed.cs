
using Claims_App.Data;
using Claims_App.Models;

namespace Claims_App
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Owners.Any())
            {
                var owners = new List<Owners>()
                {
                    new Owners()
                    {
                        FirstName = "Dany",
                        LastName = "Kravariti",
                        DriverLicence = "asf76"
                    }
                };
                dataContext.Owners.AddRange(owners);
                dataContext.SaveChanges();
            }
            if (!dataContext.Vehicles.Any())
            {
                var vehicles = new List<Vehicles>()
                {
                    new Vehicles()
                    {
                        Brand = "Mercedes",
                        Vin = 2312,
                        Color = "black",
                        Year = 2020,
                        Owner_Id = 1
                    }
                };
                dataContext.Vehicles.AddRange(vehicles);
                dataContext.SaveChanges();
            }

        }
    }
}
