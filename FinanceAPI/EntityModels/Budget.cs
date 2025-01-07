using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        [MaxLength(7)] // Format: YYYY-MM
        public string Month { get; set; }
        [Required]
        public decimal TotalBudget { get; set; }
        public decimal UsedBudget { get; set; } = 0.00m;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property if needed for relationships
        public User User { get; set; }
    }
}
