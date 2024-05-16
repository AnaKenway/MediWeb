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

    public async Task<AppointmentSlot> AddAppointmentSlotAsync(AppointmentSlot appointmentSlot)
    {
        return await _unitOfWork.AppointmentSlotRepository.InsertAsync(appointmentSlot);
    }

    public async Task<AppointmentSlot> UpdateAppointmentSlotAsync(AppointmentSlot appointmentSlot)
    {
       return await _unitOfWork.AppointmentSlotRepository.UpdateAsync(appointmentSlot);
    }

    public async Task DeleteAppointmentSlotAsync(AppointmentSlot appointmentSlot)
    {
        await _unitOfWork.AppointmentSlotRepository.DeleteAsync(appointmentSlot);
    }
}
