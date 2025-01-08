using EntityModels;
using IFinanceRepository;
using IFinanceService;

namespace FinanceService
{
    public class RecurringTransactionService : IRecurringTransactionService
    {
        private readonly IRecurringTransactionRepository _repository;

        public RecurringTransactionService(IRecurringTransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<RecurringTransaction>> GetAllRecurringTransactionsAsync()
        {
            return await _repository.GetAllRecurringTransactionsAsync();
        }

        public async Task<RecurringTransaction> GetRecurringTransactionByIdAsync(int id)
        {
            return await _repository.GetRecurringTransactionByIdAsync(id);
        }

        public async Task<IEnumerable<RecurringTransaction>> GetRecurringTransactionsByUserIdAsync(int userId)
        {
            return await _repository.GetRecurringTransactionsByUserIdAsync(userId);
        }

        public async Task AddRecurringTransactionAsync(RecurringTransaction recurringTransaction)
        {
            await _repository.AddRecurringTransactionAsync(recurringTransaction);
        }

        public async Task UpdateRecurringTransactionAsync(RecurringTransaction recurringTransaction)
        {
            await _repository.UpdateRecurringTransactionAsync(recurringTransaction);
        }

        public async Task DeleteRecurringTransactionAsync(int id)
        {
            await _repository.DeleteRecurringTransactionAsync(id);
        }
    }
}
