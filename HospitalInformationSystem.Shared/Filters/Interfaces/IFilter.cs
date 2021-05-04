using System.Linq;

namespace HospitalInformationSystem.Shared.Filters.Interfaces
{
    public interface IFilter<T> where T : class
    {
        IQueryable<T> Build(IQueryable<T> initialSet, bool applyPagination);
    }
}