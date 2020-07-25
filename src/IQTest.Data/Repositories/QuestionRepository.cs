using IQTest.Core.Entities;
using IQTest.Core.Interfaces;

namespace IQTest.Data.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
