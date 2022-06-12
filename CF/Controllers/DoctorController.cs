using CF.DTO;
using CF.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CF.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {

        private readonly IDoctorDbService _doctorDbService;

        public DoctorController(IDoctorDbService doctorDbService)
        {
            _doctorDbService = doctorDbService;
        }

        [HttpGet]
        public async Task<List<DoctorDTO>> GetDoctorListAsync()
        {
            return await _doctorDbService.GetDoctorListAsync();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateDoctorAsync([FromBody] DoctorUpdateDTO doctor)
        {
            if (await _doctorDbService.UpdateDoctorAsync(doctor) != 0)
                return Ok();
            return BadRequest("Error while updating.");
        }

        [HttpPost]
        public async Task<IActionResult> AddDoctorAsync([FromBody] DoctorDTO doctor)
        {
            if (await _doctorDbService.AddDoctorAsync(doctor) != 0)
                return Ok();
            return BadRequest("Error while adding.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDoctorAsync(int idDoctor)
        {
            if (await _doctorDbService.DeleteDoctorAsync(idDoctor) != 0)
                return Ok();
            return BadRequest("Error while deleting.");
        }
    }
}
