using EntityModels;

namespace IFinanceRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int userId);
        Task AddUserAsync(User user);
        User GetUserById(int id);
    }
}
