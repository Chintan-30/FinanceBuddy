using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using IFinanceRepository;
using IFinanceService;

namespace FinanceService
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;

        public ExpenseService(IExpenseRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Expense>> GetAllExpensesAsync()
        {
            return _repository.GetAllExpensesAsync();
        }

        public Task<Expense> GetExpenseByIdAsync(int id)
        {
            return _repository.GetExpenseByIdAsync(id);
        }

        public Task AddExpenseAsync(Expense expense)
        {
            return _repository.AddExpenseAsync(expense);
        }

        public Task UpdateExpenseAsync(Expense expense)
        {
            return _repository.UpdateExpenseAsync(expense);
        }

        public Task DeleteExpenseAsync(int id)
        {
            return _repository.DeleteExpenseAsync(id);
        }
    }

}
