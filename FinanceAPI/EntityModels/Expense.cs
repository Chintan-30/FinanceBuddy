using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Expense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public int CategoryId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public string PaidTo { get; set; }
        public bool Recurring { get; set; }
        public DateTime? NextDueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Category { get; set; }
    }
}
