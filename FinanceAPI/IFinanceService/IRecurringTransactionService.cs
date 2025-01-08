using EntityModels;

namespace IFinanceService
{
    public interface IRecurringTransactionService
    {
        Task<IEnumerable<RecurringTransaction>> GetAllRecurringTransactionsAsync();
        Task<RecurringTransaction> GetRecurringTransactionByIdAsync(int id);
        Task<IEnumerable<RecurringTransaction>> GetRecurringTransactionsByUserIdAsync(int userId);
        Task AddRecurringTransactionAsync(RecurringTransaction recurringTransaction);
        Task UpdateRecurringTransactionAsync(RecurringTransaction recurringTransaction);
        Task DeleteRecurringTransactionAsync(int id);
    }
}
