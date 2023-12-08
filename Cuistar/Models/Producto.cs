using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Producto
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdProductos { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string NombreProducto { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string DescripcionProducto { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdTipoprodu { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdUnidadmedida { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int PrecioUnitario { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdCategoria { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdTallas { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Imagen { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial757 { get; set; }

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;

    public virtual Talla IdTallasNavigation { get; set; } = null!;

    public virtual TipoProducto IdTipoproduNavigation { get; set; } = null!;

    public virtual UnidadMedidum IdUnidadmedidaNavigation { get; set; } = null!;

    public virtual ICollection<OrdenVenta> OrdenVenta { get; set; } = new List<OrdenVenta>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<StockInventario> StockInventarios { get; set; } = new List<StockInventario>();
}
