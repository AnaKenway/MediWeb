﻿using Common;

namespace DataLayer.EntityModels;

public partial class Admin
{
    public long Id { get; set; }

    public AdminType AdminType { get; set; }

    public long UserAccountId { get; set; }

    public virtual UserAccount UserAccount { get; set; } = null!;
}
