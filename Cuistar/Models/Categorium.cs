namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Categorium
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdCategoria { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial721 { get; set; }

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
