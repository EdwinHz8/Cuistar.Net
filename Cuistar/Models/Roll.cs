using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Roll
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdRol { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial760 { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
