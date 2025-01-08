using EntityModels;
using IFinanceService;
using Microsoft.AspNetCore.Mvc;

namespace FinanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecurringTransactionController : ControllerBase
    {
        private readonly IRecurringTransactionService _service;

        public RecurringTransactionController(IRecurringTransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecurringTransactions()
        {
            var transactions = await _service.GetAllRecurringTransactionsAsync();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecurringTransactionById(int id)
        {
            var transaction = await _service.GetRecurringTransactionByIdAsync(id);
            if (transaction == null) return NotFound();
            return Ok(transaction);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetRecurringTransactionsByUserId(int userId)
        {
            var transactions = await _service.GetRecurringTransactionsByUserIdAsync(userId);
            return Ok(transactions);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecurringTransaction([FromBody] RecurringTransaction recurringTransaction)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _service.AddRecurringTransactionAsync(recurringTransaction);
            return CreatedAtAction(nameof(GetRecurringTransactionById), new { id = recurringTransaction.Id }, recurringTransaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecurringTransaction(int id, [FromBody] RecurringTransaction recurringTransaction)
        {
            if (id != recurringTransaction.Id) return BadRequest("ID mismatch");
            await _service.UpdateRecurringTransactionAsync(recurringTransaction);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecurringTransaction(int id)
        {
            await _service.DeleteRecurringTransactionAsync(id);
            return NoContent();
        }
    }
}
