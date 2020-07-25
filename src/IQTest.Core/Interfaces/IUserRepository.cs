using IQTest.Core.Entities;

namespace IQTest.Core.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User Authenticate(string username, string password);
    }
}
