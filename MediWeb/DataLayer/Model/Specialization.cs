using System;
using System.Collections.Generic;

namespace DataLayer.Model;

public partial class Specialization
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<DoctorWorksAtClinic> DoctorWorksAtClinics { get; set; } = new List<DoctorWorksAtClinic>();
}
