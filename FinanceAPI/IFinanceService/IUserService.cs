using EntityModels;

namespace IFinanceService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}
