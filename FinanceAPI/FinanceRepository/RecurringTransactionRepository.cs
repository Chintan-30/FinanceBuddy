using EntityModels;
using IFinanceRepository;
using Microsoft.EntityFrameworkCore;

namespace FinanceRepository
{
    public class RecurringTransactionRepository : IRecurringTransactionRepository
    {
        private readonly AppDbContext _context;

        public RecurringTransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RecurringTransaction>> GetAllRecurringTransactionsAsync()
        {
            return await _context.RecurringTransactions.ToListAsync();
        }

        public async Task<RecurringTransaction> GetRecurringTransactionByIdAsync(int id)
        {
            return await _context.RecurringTransactions.FindAsync(id);
        }

        public async Task<IEnumerable<RecurringTransaction>> GetRecurringTransactionsByUserIdAsync(int userId)
        {
            return await _context.RecurringTransactions.Where(rt => rt.UserId == userId).ToListAsync();
        }

        public async Task AddRecurringTransactionAsync(RecurringTransaction recurringTransaction)
        {
            _context.RecurringTransactions.Add(recurringTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRecurringTransactionAsync(RecurringTransaction recurringTransaction)
        {
            _context.RecurringTransactions.Update(recurringTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRecurringTransactionAsync(int id)
        {
            var recurringTransaction = await _context.RecurringTransactions.FindAsync(id);
            if (recurringTransaction != null)
            {
                _context.RecurringTransactions.Remove(recurringTransaction);
                await _context.SaveChangesAsync();
            }
        }
    }
}

