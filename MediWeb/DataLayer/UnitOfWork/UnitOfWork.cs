using DataLayer.Repository;

namespace DataLayer;

public class UnitOfWork : IDisposable
{
    private MediwebContext _context;
    private AdminRepository? adminRepository;
    private AppointmentRepository? appointmentRepository;
    private AppointmentSlotRepository? appointmentSlotRepository;
    private ClinicRepository? clinicRepository;
    private DoctorRepository? doctorRepository;
    private DoctorWorksAtClinicRepository? doctorWorksAtClinicRepository;
    private MedicalStaffRepository? medicalStaffRepository;
    private PatientRepository? patientRepository;
    private SpecializationRepository? specializationRepository;
    private UserAccountRepository? userAccountRepository;
    private bool disposedValue;
   
    public UnitOfWork(MediwebContext context)
    {
        _context = context;
    }

    public AdminRepository AdminRepository
    {
        get
        {
            adminRepository ??= new AdminRepository(_context);
            return adminRepository;
        }
    }

    public AppointmentRepository AppointmentRepository
    {
        get
        {
            appointmentRepository ??= new AppointmentRepository(_context);
            return appointmentRepository;
        }
    }

    public AppointmentSlotRepository AppointmentSlotRepository
    {
        get
        {
            appointmentSlotRepository ??= new AppointmentSlotRepository(_context);
            return appointmentSlotRepository;
        }
    }

    public ClinicRepository ClinicRepository
    {
        get
        {
            clinicRepository ??= new ClinicRepository(_context);
            return clinicRepository;
        }
    }

    public DoctorRepository DoctorRepository
    {
        get
        {
            doctorRepository ??= new DoctorRepository(_context);
            return doctorRepository;
        }
    }

    public DoctorWorksAtClinicRepository DoctorWorksAtClinicRepository
    {
        get
        {
            doctorWorksAtClinicRepository ??= new DoctorWorksAtClinicRepository(_context);
            return doctorWorksAtClinicRepository;
        }
    }

    public MedicalStaffRepository MedicalStaffRepository
    {
        get
        {
            medicalStaffRepository ??= new MedicalStaffRepository(_context);
            return medicalStaffRepository;
        }
    }

    public PatientRepository PatientRepository
    {
        get
        {
            patientRepository ??= new PatientRepository(_context);
            return patientRepository;
        }
    }

    public SpecializationRepository SpecializationRepository
    {
        get
        {
            specializationRepository ??= new SpecializationRepository(_context);
            return specializationRepository;
        }
    }

    public UserAccountRepository UserAccountRepository
    {
        get
        {
            userAccountRepository ??= new UserAccountRepository(_context);
            return userAccountRepository;
        }
    }


    public void Save()
    {
        _context.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                _context.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~UnitOfWork()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
