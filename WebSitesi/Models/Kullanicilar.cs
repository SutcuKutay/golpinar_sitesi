﻿using System;
using System.Collections.Generic;

namespace WebSitesi.Models;

public partial class Kullanicilar
{
    public int Id { get; set; }

    public string KullaniciAdi { get; set; } = null!;

    public string Sifre { get; set; } = null!;
}
