using IQTest.Core.Entities;
using IQTest.Core.Interfaces;
using IQTest.Data.Helpers;
using System.Linq;

namespace IQTest.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            var user = _context.Users.SingleOrDefault(u => u.Username == username);

            if (user == null)
            {
                return null;
            }

            if (!HashHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            return user;
        }
    }
}
