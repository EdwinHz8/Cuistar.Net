﻿namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Estatura
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdEstatura { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial747 { get; set; }

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();
}
