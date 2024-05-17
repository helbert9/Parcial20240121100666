using System;
using System.Collections.Generic;

namespace SportAPI.Data;

public partial class Sport
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Country { get; set; }

    public DateOnly? FundationDate { get; set; }
}
