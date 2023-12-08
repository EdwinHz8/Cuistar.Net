using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Peso
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdPeso { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial754 { get; set; }

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();
}
