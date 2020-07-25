using IQTest.Core.Interfaces;
using IQTest.Data.Repositories;

namespace IQTest.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Questions = new QuestionRepository(_context);
            Options = new OptionRepository(_context);
            Users = new UserRepository(_context);
            ContactMessages = new ContactMessageRepository(_context);
        }

        public IQuestionRepository Questions { get; private set; }
        public IOptionRepository Options { get; private set; }
        public IUserRepository Users { get; private set; }
        public IContactMessageRepository ContactMessages { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
