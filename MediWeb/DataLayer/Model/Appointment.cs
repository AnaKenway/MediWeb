using System;
using System.Collections;
using System.Collections.Generic;

namespace DataLayer.Model;

public partial class Appointment
{
    public long Id { get; set; }

    public string Note { get; set; } = null!;

    public BitArray IsApproved { get; set; } = null!;

    public long PatientId { get; set; }

    public long AppointmentSlotId { get; set; }

    public virtual AppointmentSlot AppointmentSlot { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
