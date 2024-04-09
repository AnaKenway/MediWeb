
namespace Data.Models;

public partial class AppointmentSlot
{
    public long Id { get; set; }

    public long DoctorId { get; set; }

    public long ClinicId { get; set; }

    public DateTime DateAndTime { get; set; }

    public int DurationInMinutes { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Clinic Clinic { get; set; } = null!;

    public virtual Doctor Doctor { get; set; } = null!;
}
