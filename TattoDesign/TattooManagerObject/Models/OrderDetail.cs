using System;
using System.Collections.Generic;

namespace TattooManagerObject.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int OrderId { get; set; }

    public int TattooId { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual TattooImg Tattoo { get; set; } = null!;
}
