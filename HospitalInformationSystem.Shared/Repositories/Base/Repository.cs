using HospitalInformationSystem.Shared.Filters.Interfaces;
using HospitalInformationSystem.Shared.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalInformationSystem.Shared.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly HospitalInformationSystemDbContext _context;
        private readonly DbSet<T> _table;

        public Repository(HospitalInformationSystemDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> Get() => await _table.ToListAsync();

        public async Task<IEnumerable<T>> Get(IFilter<T> filter) => await filter.Build(_table).ToListAsync();

        public async Task<T> Get(object id) => await _table.FindAsync(id);

        public async Task<T> Add(T entity) => (await _table.AddAsync(entity)).Entity;

        public async Task<T> Delete(object id) => _table.Remove(await Get(id)).Entity;

        public async Task<T> Update(T entity)
        {
            await Add(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}