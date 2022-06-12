using CF.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionDbService _prescriptionDbService;

        public PrescriptionController(IPrescriptionDbService prescriptionDbService)
        {
            _prescriptionDbService = prescriptionDbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDataPrescriptionAsync(int idPrescription)
        {
            var result = await _prescriptionDbService.GetDataPrescriptionAsync(idPrescription);
            return Ok(result);
        }
    }
}
