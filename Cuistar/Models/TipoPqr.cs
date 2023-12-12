namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class TipoPqr
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdTipo { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial773 { get; set; }

    public virtual ICollection<Pqr> Pqrs { get; set; } = new List<Pqr>();
}
