using EntityModels;
using Microsoft.EntityFrameworkCore;

namespace FinanceRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Income> Incomes { get; set; } 
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<RecurringTransaction> RecurringTransactions { get; set; }
    }
}
