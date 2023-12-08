using System;
using System.Collections.Generic;

namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Pqr
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdPqrs { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdUsuario { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdTipo { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int Asunto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTime Fecha { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Evidencia { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Respuesta { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdEstado { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial757 { get; set; }

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual TipoPqr IdTipoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
