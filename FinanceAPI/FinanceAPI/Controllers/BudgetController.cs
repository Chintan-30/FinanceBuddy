using EntityModels;
using IFinanceService;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetService _service;

        public BudgetController(IBudgetService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBudgets()
        {
            var budgets = await _service.GetAllBudgetsAsync();
            return Ok(budgets);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBudgetById(int id)
        {
            var budget = await _service.GetBudgetByIdAsync(id);
            if (budget == null) return NotFound();
            return Ok(budget);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetBudgetsByUserId(int userId)
        {
            var budgets = await _service.GetBudgetsByUserIdAsync(userId);
            return Ok(budgets);
        }

        [HttpPost]
        public async Task<IActionResult> AddBudget([FromBody] Budget budget)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _service.AddBudgetAsync(budget);
            return CreatedAtAction(nameof(GetBudgetById), new { id = budget.Id }, budget);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBudget(int id, [FromBody] Budget budget)
        {
            if (id != budget.Id) return BadRequest("Budget ID mismatch");
            await _service.UpdateBudgetAsync(budget);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBudget(int id)
        {
            await _service.DeleteBudgetAsync(id);
            return NoContent();
        }
    }
}
