using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class OrdenVenta
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdVentas { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdInventario { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int CantidasProductos { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdSalida { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int PrecioTotal { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdTipoPago { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdUsuario { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial754 { get; set; }

    public virtual Producto IdInventarioNavigation { get; set; } = null!;

    public virtual TipoPago IdTipoPagoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
