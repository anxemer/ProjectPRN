using System;
using System.Collections.Generic;

namespace TattooManagerObject.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int UserId { get; set; }

    public int TattooId { get; set; }

    public int? Quantity { get; set; }

    public DateTime? DateAdded { get; set; }

    public virtual TattooImg Tattoo { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
