using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class Evler
{
    public int Id { get; set; }

    public byte Numara { get; set; }

    public int Sahibi { get; set; }

    public int? Kiracı { get; set; }

    public virtual ICollection<Aidatlar> Aidatlars { get; set; } = new List<Aidatlar>();

    public virtual Kiracilar? KiracıNavigation { get; set; }

    public virtual SiteSakinleri SahibiNavigation { get; set; } = null!;
}
