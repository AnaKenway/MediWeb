using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class AppointmentSlotService
{
    private readonly UnitOfWork _unitOfWork;

    public AppointmentSlotService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<AppointmentSlot>> GetAllAppointmentSlotsAsync()
    {
        return await _unitOfWork.AppointmentSlotRepository.GetAllAsync();
    }

    public async Task<AppointmentSlot> GetAppointmentSlotByIdAsync(long id)
    {
        return await _unitOfWork.AppointmentSlotRepository.GetByIdAsync(id);
    }

    public async Task AddAppointmentSlotAsync(AppointmentSlot appointmentSlot)
    {
        await _unitOfWork.AppointmentSlotRepository.InsertAsync(appointmentSlot);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateAppointmentSlotAsync(AppointmentSlot appointmentSlot)
    {
        await _unitOfWork.AppointmentSlotRepository.UpdateAsync(appointmentSlot);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteAppointmentSlotAsync(AppointmentSlot appointmentSlot)
    {
        await _unitOfWork.AppointmentSlotRepository.DeleteAsync(appointmentSlot);
        await _unitOfWork.SaveAsync();

    }
}
