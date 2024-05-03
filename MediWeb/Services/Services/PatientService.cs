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

    public async Task AddPatientAsync(Patient patient)
    {
        await _unitOfWork.PatientRepository.InsertAsync(patient);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdatePatientAsync(Patient patient)
    {
        await _unitOfWork.PatientRepository.UpdateAsync(patient);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeletePatientAsync(long id)
    {
        await _unitOfWork.PatientRepository.DeleteAsync(id);
        await _unitOfWork.SaveAsync();

    }
}
