using System;
using System.Collections.Generic;

namespace DataLayer.Model;

public partial class Doctor
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public long UserAccountId { get; set; }

    public virtual ICollection<AppointmentSlot> AppointmentSlots { get; set; } = new List<AppointmentSlot>();

    public virtual ICollection<DoctorWorksAtClinic> DoctorWorksAtClinics { get; set; } = new List<DoctorWorksAtClinic>();

    public virtual UserAccount UserAccount { get; set; } = null!;
}
