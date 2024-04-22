using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class Aidatlar
{
    public int Id { get; set; }

    public int Ev { get; set; }

    public decimal? OdenmemisAidat { get; set; }

    public DateTime OdemeTarihi { get; set; }

    public virtual Evler EvNavigation { get; set; } = null!;
}
