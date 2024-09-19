﻿using System;
using System.Collections.Generic;

namespace demo2;

public partial class Gender
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
