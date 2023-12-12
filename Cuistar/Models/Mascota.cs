namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Mascota
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdMascota { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdUsuario { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdGenero { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string NombreMascota { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int EdadMascota { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdPeso { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Raza { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdCategoria { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdEstatura { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial750 { get; set; }

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;

    public virtual Estatura IdEstaturaNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;

    public virtual Peso IdPesoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
