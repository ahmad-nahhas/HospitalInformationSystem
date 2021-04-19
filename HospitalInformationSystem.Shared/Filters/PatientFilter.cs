using HospitalInformationSystem.Shared.Entities;
using HospitalInformationSystem.Shared.Filters.Base;
using HospitalInformationSystem.Shared.Filters.Interfaces;
using System.Linq;

namespace HospitalInformationSystem.Shared.Filters
{
    public class PatientFilter : PaginationFilter<Patient>, IFilter<Patient>
    {
        public string Name { get; set; }
        public decimal? FileNo { get; set; }
        public string PhoneNumber { get; set; }

        public IQueryable<Patient> Build(IQueryable<Patient> initialSet, bool applyPagination = true)
        {
            if (!string.IsNullOrWhiteSpace(Name))
                initialSet = initialSet.Where(i => i.Name.ToLower().Contains(Name.ToLower()));

            if (FileNo.HasValue && FileNo.Value > 0)
                initialSet = initialSet.Where(i => i.FileNo == FileNo);

            if (!string.IsNullOrWhiteSpace(PhoneNumber))
                initialSet = initialSet.Where(i => i.PhoneNumber.ToLower().Contains(PhoneNumber.ToLower()));

            return applyPagination ? ConfigurePagination(initialSet) : initialSet;
        }
    }
}