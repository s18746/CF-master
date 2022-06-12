using CF.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CF.Services.Interfaces
{
    public interface IDoctorDbService
    {
        Task<List<DoctorDTO>> GetDoctorListAsync();
        Task<int> AddDoctorAsync(DoctorDTO doctor);
        Task<int> UpdateDoctorAsync(DoctorUpdateDTO doctor);
        Task<int> DeleteDoctorAsync(int idDoctor);
    }
}
