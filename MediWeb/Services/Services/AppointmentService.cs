using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class AppointmentService
{
    private readonly UnitOfWork _unitOfWork;

    public AppointmentService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
    {
        return await _unitOfWork.AppointmentRepository.GetAllAsync();
    }

    public async Task<Appointment> GetAppointmentByIdAsync(long id)
    {
        return await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
    }

    public async Task AddAppointmentAsync(Appointment appointment)
    {
        await _unitOfWork.AppointmentRepository.InsertAsync(appointment);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateAppointmentAsync(Appointment appointment)
    {
        await _unitOfWork.AppointmentRepository.UpdateAsync(appointment);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteAppointmentAsync(Appointment appointment)
    {
        await _unitOfWork.AppointmentRepository.DeleteAsync(appointment);
        await _unitOfWork.SaveAsync();

    }
}
