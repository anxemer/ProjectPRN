using System;
using System.Collections.Generic;

namespace TattooManagerObject.Models;

public partial class CategoryTattoo
{
    public int Id { get; set; }

    public string? CateName { get; set; }

    public virtual ICollection<TattooImg> TattooImgs { get; set; } = new List<TattooImg>();
}
