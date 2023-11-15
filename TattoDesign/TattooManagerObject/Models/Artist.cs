using System;
using System.Collections.Generic;

namespace TattooManagerObject.Models;

public partial class Artist
{
    public int Id { get; set; }

    public string? Namestaff { get; set; }

    public string? Information { get; set; }

    public string? Experience { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
