﻿using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class MedicalStaffService
{
    private readonly UnitOfWork _unitOfWork;

    public MedicalStaffService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<MedicalStaff>> GetAllMedicalStaffAsync()
    {
        return await _unitOfWork.MedicalStaffRepository.GetAllAsync();
    }

    public async Task<MedicalStaff> GetMedicalStaffByIdAsync(long id)
    {
        return await _unitOfWork.MedicalStaffRepository.GetByIdAsync(id);
    }

    public async Task AddMedicalStaffAsync(MedicalStaff medicalStaff)
    {
        await _unitOfWork.MedicalStaffRepository.InsertAsync(medicalStaff);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateMedicalStaffAsync(MedicalStaff medicalStaff)
    {
        await _unitOfWork.MedicalStaffRepository.UpdateAsync(medicalStaff);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteMedicalStaffAsync(MedicalStaff medicalStaff)
    {
        await _unitOfWork.MedicalStaffRepository.DeleteAsync(medicalStaff);
        await _unitOfWork.SaveAsync();

    }
}
