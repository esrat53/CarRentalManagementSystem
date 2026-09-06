namespace CarRentalManagementSystem.Models
{
    public abstract class Vehicle
    {
        public int VehicleID { get; set; }

        public int OwnerID { get; set; }

        public string Brand { get; set; } = "";

        public string Model { get; set; } = "";

        public int Year { get; set; }

        public string VehicleType { get; set; } = "";

        public int Seats { get; set; }

        public decimal PricePerDay { get; set; }

        public string AvailabilityStatus { get; set; } = "";

        public string Description { get; set; } = "";

        public string ImagePath { get; set; } = "";

        public string Location { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}