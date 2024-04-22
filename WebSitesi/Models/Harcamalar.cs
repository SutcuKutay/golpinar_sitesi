using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class Harcamalar
{
    public int Id { get; set; }

    public DateTime Tarih { get; set; }

    public decimal? ToplamHarcama { get; set; }

    public virtual ICollection<HarcamaDetay> HarcamaDetays { get; set; } = new List<HarcamaDetay>();
}
