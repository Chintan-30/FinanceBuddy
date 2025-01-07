using EntityModels;

namespace IFinanceRepository
{
    public interface IBudgetRepository
    {
        Task<IEnumerable<Budget>> GetAllBudgetsAsync();
        Task<Budget> GetBudgetByIdAsync(int id);
        Task<IEnumerable<Budget>> GetBudgetsByUserIdAsync(int userId);
        Task AddBudgetAsync(Budget budget);
        Task UpdateBudgetAsync(Budget budget);
        Task DeleteBudgetAsync(int id);
    }
}
