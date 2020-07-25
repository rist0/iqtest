using IQTest.Core.Entities;
using IQTest.Core.Interfaces;

namespace IQTest.Data.Repositories
{
    public class ContactMessageRepository : GenericRepository<ContactMessage>, IContactMessageRepository
    {
        public ContactMessageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
