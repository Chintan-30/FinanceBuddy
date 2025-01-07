using EntityModels;
using IFinanceRepository;
using IFinanceService;

namespace FinanceService
{
    public class BudgetService : IBudgetService
    {
        private readonly IBudgetRepository _repository;

        public BudgetService(IBudgetRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Budget>> GetAllBudgetsAsync()
        {
            return await _repository.GetAllBudgetsAsync();
        }

        public async Task<Budget> GetBudgetByIdAsync(int id)
        {
            return await _repository.GetBudgetByIdAsync(id);
        }

        public async Task<IEnumerable<Budget>> GetBudgetsByUserIdAsync(int userId)
        {
            return await _repository.GetBudgetsByUserIdAsync(userId);
        }

        public async Task AddBudgetAsync(Budget budget)
        {
            await _repository.AddBudgetAsync(budget);
        }

        public async Task UpdateBudgetAsync(Budget budget)
        {
            await _repository.UpdateBudgetAsync(budget);
        }

        public async Task DeleteBudgetAsync(int id)
        {
            await _repository.DeleteBudgetAsync(id);
        }
    }
}