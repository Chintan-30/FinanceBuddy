using EntityModels;
using IFinanceRepository;
using IFinanceService;

namespace FinanceService
{
    public class IncomeService : IIncomeService
    {
        private readonly IIncomeRepository _repository;

        public IncomeService(IIncomeRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Income>> GetAllIncomesAsync()
        {
            return _repository.GetAllIncomesAsync();
        }

        public Task<Income> GetIncomeByIdAsync(int id)
        {
            return _repository.GetIncomeByIdAsync(id);
        }

        public Task AddIncomeAsync(Income income)
        {
            return _repository.AddIncomeAsync(income);
        }

        public Task UpdateIncomeAsync(Income income)
        {
            return _repository.UpdateIncomeAsync(income);
        }

        public Task DeleteIncomeAsync(int id)
        {
            return _repository.DeleteIncomeAsync(id);
        }
    }

    // Repeat for ExpenseService

}
