using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using IFinanceRepository;
using Microsoft.EntityFrameworkCore;

namespace FinanceRepository
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly AppDbContext _context;

        public IncomeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Income>> GetAllIncomesAsync()
        {
            return await _context.Incomes.ToListAsync();
        }

        public async Task<Income> GetIncomeByIdAsync(int id)
        {
            return await _context.Incomes.FindAsync(id);
        }

        public async Task AddIncomeAsync(Income income)
        {
            await _context.Incomes.AddAsync(income);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateIncomeAsync(Income income)
        {
            _context.Incomes.Update(income);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIncomeAsync(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            if (income != null)
            {
                _context.Incomes.Remove(income);
                await _context.SaveChangesAsync();
            }
        }
    }


}
