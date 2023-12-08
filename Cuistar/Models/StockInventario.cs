using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class StockInventario
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdInventario { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdProducto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int CantidadActual { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int Entradas { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdSalidas { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int PrecioTotal { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial767 { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Salida IdSalidasNavigation { get; set; } = null!;
}
