using EntityModels;
using IFinanceRepository;
using Microsoft.EntityFrameworkCore;

namespace FinanceRepository
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly AppDbContext _context;

        public BudgetRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Budget>> GetAllBudgetsAsync()
        {
            return await _context.Budgets.ToListAsync();
        }

        public async Task<Budget> GetBudgetByIdAsync(int id)
        {
            return await _context.Budgets.FindAsync(id);
        }

        public async Task<IEnumerable<Budget>> GetBudgetsByUserIdAsync(int userId)
        {
            return await _context.Budgets.Where(b => b.UserId == userId).ToListAsync();
        }

        public async Task AddBudgetAsync(Budget budget)
        {
            _context.Budgets.Add(budget);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBudgetAsync(Budget budget)
        {
            _context.Budgets.Update(budget);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBudgetAsync(int id)
        {
            var budget = await _context.Budgets.FindAsync(id);
            if (budget != null)
            {
                _context.Budgets.Remove(budget);
                await _context.SaveChangesAsync();
            }
        }

    }
}