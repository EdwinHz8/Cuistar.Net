namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Salida
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdSalida { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public decimal? ValorSalida { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial763 { get; set; }

    public virtual ICollection<StockInventario> StockInventarios { get; set; } = new List<StockInventario>();
}
