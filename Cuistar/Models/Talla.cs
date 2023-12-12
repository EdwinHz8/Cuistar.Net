namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Talla
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdTallas { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial770 { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
