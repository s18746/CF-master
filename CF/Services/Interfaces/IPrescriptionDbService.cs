using CF.DTO;
using System.Threading.Tasks;

namespace CF.Services.Interfaces
{
    public interface IPrescriptionDbService
    {
        Task<PrescriptionDTO> GetDataPrescriptionAsync(int idPrescription);
    }
}
