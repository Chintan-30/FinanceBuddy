namespace EntityModels
{
    public class Income
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Source { get; set; }
        public DateTime IncomeDate { get; set; }
        public int CategoryId { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public bool Recurring { get; set; }
        public DateTime? NextDueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
