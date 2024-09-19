using System;
using System.Collections.Generic;

namespace demo2;

public partial class Tagofclient
{
    public int Clientid { get; set; }

    public int Tagid { get; set; }

    public virtual Client Client { get; set; } = null!;
}
