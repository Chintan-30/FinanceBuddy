using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;

namespace IFinanceRepository
{
    public interface IIncomeRepository
    {
        Task<IEnumerable<Income>> GetAllIncomesAsync();
        Task<Income> GetIncomeByIdAsync(int id);
        Task AddIncomeAsync(Income income);
        Task DeleteIncomeAsync(int id);
        Task UpdateIncomeAsync(Income income);
    }
}
