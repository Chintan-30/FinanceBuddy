using EntityModels;
using IFinanceRepository;
using IFinanceService;

namespace FinanceService
{
    public class UserService: IUserService
    {
        public readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            userRepository = _userRepository;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

    }
}
