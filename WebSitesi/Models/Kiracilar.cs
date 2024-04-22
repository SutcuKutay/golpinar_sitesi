using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class Kiracilar
{
    public int Id { get; set; }

    public string AdSoyad { get; set; } = null!;

    public string Gsm { get; set; } = null!;

    public virtual ICollection<Evler> Evlers { get; set; } = new List<Evler>();
}
