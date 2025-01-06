using Dapper;
using EntityModels;
using IFinanceRepository;
using Microsoft.EntityFrameworkCore;

namespace FinanceRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly DatabaseConnection _databaseConnection;
        public UserRepository(AppDbContext context, DatabaseConnection databaseConnection)
        {
            _context = context;
            _databaseConnection = databaseConnection;
        }
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Id == userId);
        }
        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public User GetUserById(int id)
        {
            using (var connection = _databaseConnection.CreateConnection())
            {
                const string query = "SELECT * FROM Users WHERE id = @Id;";
                return connection.QueryFirstOrDefault<User>(query, new { Id = id });
            }
        }

    }
}
