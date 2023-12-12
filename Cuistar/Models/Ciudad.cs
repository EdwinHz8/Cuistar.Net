namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Ciudad
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdCiudad { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial744 { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
