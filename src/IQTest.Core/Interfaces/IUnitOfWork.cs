using System;

namespace IQTest.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IQuestionRepository Questions { get; }
        IOptionRepository Options { get; }
        IUserRepository Users { get; }
        IContactMessageRepository ContactMessages { get; }
        int Complete();
    }
}
