using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class Item
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? IsComplete { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
