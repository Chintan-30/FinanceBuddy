using EntityModels;
using IFinanceService;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {
        private readonly IIncomeService _service;

        public IncomeController(IIncomeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIncomes()
        {
            var incomes = await _service.GetAllIncomesAsync();
            return Ok(incomes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIncomeById(int id)
        {
            var income = await _service.GetIncomeByIdAsync(id);
            if (income == null) return NotFound();
            return Ok(income);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIncome([FromBody] Income income)
        {
            await _service.AddIncomeAsync(income);
            return CreatedAtAction(nameof(GetIncomeById), new { id = income.Id }, income);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIncome(int id, [FromBody] Income income)
        {
            if (id != income.Id) return BadRequest();
            await _service.UpdateIncomeAsync(income);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncome(int id)
        {
            await _service.DeleteIncomeAsync(id);
            return NoContent();
        }
    }

    // Repeat for ExpenseController

}
