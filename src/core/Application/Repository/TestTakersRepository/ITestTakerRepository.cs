using Application.Domain.Entities;
using Application.Repository;

namespace Application.Repository.TestTakersRepository
{
    public interface ITestTakerRepository : IBaseRepository<TestTakers>
    {
        Task<TestTakers> GetByID(string BannerID, CancellationToken cancellationToken);

    }
}
