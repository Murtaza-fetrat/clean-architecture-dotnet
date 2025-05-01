using Application.Domain.Entities;
using Application.Presistence.Context;
using Application.Repository.TestTakersRepository;
using Microsoft.EntityFrameworkCore;


namespace Application.Presistence.Repository.TestTakersRepository
{
    public class TestTakerRepository : BaseRepository<TestTakers>, ITestTakerRepository
    {
        public TestTakerRepository(DataBaseContext context) : base(context)
        {
        }

        public Task<TestTakers> GetByID(string BannerID, CancellationToken cancellationToken)
        {
            return Context.TestTakers.FirstOrDefaultAsync(x => x.BannerID == BannerID, cancellationToken);
        }
    }
}
