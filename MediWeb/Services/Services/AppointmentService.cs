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

    public IEnumerable<Appointment> GetAllAppointments()
    {
        return _unitOfWork.AppointmentRepository.GetAll();
    }

    public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync()
    {
        return await _unitOfWork.AppointmentRepository.GetAllAsync();
    }

    public async Task<Appointment> GetAppointmentByIdAsync(long id)
    {
        return await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
    }

    public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
    {
        return await _unitOfWork.AppointmentRepository.InsertAsync(appointment);
    }

    public async Task<Appointment> UpdateAppointmentAsync(Appointment appointment)
    {
        return await _unitOfWork.AppointmentRepository.UpdateAsync(appointment);
    }

    public async Task DeleteAppointmentAsync(Appointment appointment)
    {
        await _unitOfWork.AppointmentRepository.DeleteAsync(appointment);
    }
}
