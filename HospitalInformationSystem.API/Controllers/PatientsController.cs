using HospitalInformationSystem.API.Controllers.Base;
using HospitalInformationSystem.Shared.Entities;
using HospitalInformationSystem.Shared.Filters;
using HospitalInformationSystem.Shared.UnitOfWorks.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalInformationSystem.API.Controllers
{
    public class PatientsController : ControllerBase<Patient, PatientFilter>
    {
        private readonly IUnitOfWork<Patient> _uow;

        public PatientsController(IUnitOfWork<Patient> uow) : base(uow)
        {
            _uow = uow;
        }

        public async override Task<ActionResult<Patient>> Post([FromBody] Patient patient)
        {
            if (await IsExist(patient.FileNo))
                return BadRequest($"Patient with file number {patient.FileNo} already exists!");

            if (await IsExist(patient.CitizenId))
                return BadRequest($"Patient with Citizen Identity {patient.CitizenId} already exists!");

            return await base.Post(patient);
        }

        private async Task<bool> IsExist(decimal fileNo) =>
            (await _uow.Repository.Get()).Any(p => p.FileNo == fileNo);

        private async Task<bool> IsExist(string citizenId) =>
            (await _uow.Repository.Get()).Any(p => p.CitizenId == citizenId);
    }
}