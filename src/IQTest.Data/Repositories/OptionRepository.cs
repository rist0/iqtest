using IQTest.Core.Entities;
using IQTest.Core.Interfaces;

namespace IQTest.Data.Repositories
{
    public class OptionRepository : GenericRepository<Option>, IOptionRepository
    {
        public OptionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
