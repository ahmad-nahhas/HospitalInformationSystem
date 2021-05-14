using System.Linq;

namespace HospitalInformationSystem.Shared.Filters.Base
{
    public abstract class PaginationFilter<T> where T : class
    {
        private const int _defaultPageNumber = 1;
        private const int _defaultPageSize = 6;

        private int _pageNumber = _defaultPageNumber;
        private int _pageSize = _defaultPageSize;

        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = (value < 1) ? _defaultPageNumber : value;
        }
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value < 1) ? _defaultPageSize :
                (value > _defaultPageSize) ? _defaultPageSize : value;
        }

        public IQueryable<T> ConfigurePagination(IQueryable<T> initialSet)
            => initialSet.Skip((PageNumber - 1) * PageSize).Take(PageSize);
    }
}