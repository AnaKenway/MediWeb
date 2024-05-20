using System;
using System.Collections.Generic;

namespace DataLayer.Model;

public partial class Admin
{
    public long Id { get; set; }

    public int AdminType { get; set; }

    public long UserAccountId { get; set; }

    public virtual UserAccount UserAccount { get; set; } = null!;
}
