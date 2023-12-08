using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Estado
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdEstado { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial744 { get; set; }

    public virtual ICollection<Pqr> Pqrs { get; set; } = new List<Pqr>();
}
