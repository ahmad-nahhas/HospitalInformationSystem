using HospitalInformationSystem.Shared.Repositories.Base;
using HospitalInformationSystem.Shared.Repositories.Interfaces;
using HospitalInformationSystem.Shared.UnitOfWorks.Interfaces;
using System.Threading.Tasks;

namespace HospitalInformationSystem.Shared.UnitOfWorks.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly HospitalInformationSystemDbContext _context;
        private Repository<T> _repository;

        public UnitOfWork(HospitalInformationSystemDbContext context)
        {
            _context = context;
        }
        public IRepository<T> Repository => _repository ??= new Repository<T>(_context);
        public async Task<int> Save() => await _context.SaveChangesAsync();
    }
}