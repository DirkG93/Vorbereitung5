using System;
using System.Collections.Generic;

namespace Vorbereitung_5.Models;

public partial class Wohnung
{
    public int WohnungId { get; set; }

    public string Ort { get; set; } = null!;

    public int Zimmer { get; set; }

    public int FlaecheQm { get; set; }

    public decimal MieteChf { get; set; }

    public bool Balkon { get; set; }
}
