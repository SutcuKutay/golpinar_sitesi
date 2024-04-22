using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class SiteSakinleri
{
    public int Id { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public virtual ICollection<Evler> Evlers { get; set; } = new List<Evler>();
}
