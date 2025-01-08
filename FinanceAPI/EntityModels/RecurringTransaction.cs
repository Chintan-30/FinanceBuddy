using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    [Table("RecurringTransactions")]
    public class RecurringTransaction
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int CategoryId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string Frequency { get; set; } // ENUM('daily', 'weekly', 'monthly', 'yearly')

        [Required]
        public DateTime NextDueDate { get; set; }

        [Required]
        public string Type { get; set; } // ENUM('income', 'expense')

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties if required
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
