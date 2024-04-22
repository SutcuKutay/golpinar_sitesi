using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class HarcamaDetay
{
    public int Id { get; set; }

    public int HarcamaId { get; set; }

    public string Aciklama { get; set; } = null!;

    public decimal Harcama { get; set; }

    public virtual Harcamalar HarcamaNavigation { get; set; } = null!;
}
