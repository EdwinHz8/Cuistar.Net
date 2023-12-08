using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Proveedore
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdNit { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Nombres { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Apellidos { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Teléfono { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Direccion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Correo { get; set; } = null!;

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
    public string? Trial760 { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
