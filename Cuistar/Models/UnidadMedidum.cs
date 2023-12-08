using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class UnidadMedidum
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdUnidadmedida { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial776 { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
