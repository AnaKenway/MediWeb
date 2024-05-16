using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class PatientService
{
    private readonly UnitOfWork _unitOfWork;

    public PatientService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
    {
        return await _unitOfWork.PatientRepository.GetAllAsync();
    }

    public async Task<Patient> GetPatientByIdAsync(long id)
    {
        return await _unitOfWork.PatientRepository.GetByIdAsync(id);
    }

    public async Task<Patient> AddPatientAsync(Patient patient)
    {
        return await _unitOfWork.PatientRepository.InsertAsync(patient);
    }

    public async Task<Patient> UpdatePatientAsync(Patient patient)
    {
        return await _unitOfWork.PatientRepository.UpdateAsync(patient);
    }

    public async Task DeletePatientAsync(Patient patient)
    {
        await _unitOfWork.PatientRepository.DeleteAsync(patient);
    }
}
