namespace CarRentalManagementSystem.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }

        public int BookingID { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
