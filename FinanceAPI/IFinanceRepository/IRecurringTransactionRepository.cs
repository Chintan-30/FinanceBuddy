using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFinanceRepository
{
    public interface IRecurringTransactionRepository
    {
        Task<IEnumerable<RecurringTransaction>> GetAllRecurringTransactionsAsync();
        Task<RecurringTransaction> GetRecurringTransactionByIdAsync(int id);
        Task<IEnumerable<RecurringTransaction>> GetRecurringTransactionsByUserIdAsync(int userId);
        Task AddRecurringTransactionAsync(RecurringTransaction recurringTransaction);
        Task UpdateRecurringTransactionAsync(RecurringTransaction recurringTransaction);
        Task DeleteRecurringTransactionAsync(int id);
    }
}
