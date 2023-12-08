using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class TipoPago
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdPago { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial770 { get; set; }

    public virtual ICollection<OrdenVenta> OrdenVenta { get; set; } = new List<OrdenVenta>();
}
