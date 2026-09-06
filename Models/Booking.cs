namespace CarRentalManagementSystem.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int CustomerID { get; set; }

        public int VehicleID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string BookingStatus { get; set; }
    }
}
