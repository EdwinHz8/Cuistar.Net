using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Cuistar.Models;

/// <summary>
/// TRIAL
/// </summary>
public partial class Usuario
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdUsuario { get; set; }

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
    public string Correo { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Contrasena { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Telefono { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdRoll { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int IdCiudad { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int Cedula { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial780 { get; set; }

    [Display(Name = "Id_Ciudad")]
    public virtual Ciudad IdCiudadNavigation { get; set; } = null!;
    [Display(Name = "Id_Rol")]
    public virtual Roll IdRollNavigation { get; set; } = null!;

    public virtual ICollection<Mascota> Mascota { get; set; } = new List<Mascota>();

    public virtual ICollection<OrdenVenta> OrdenVenta { get; set; } = new List<OrdenVenta>();

    public virtual ICollection<Pqr> Pqrs { get; set; } = new List<Pqr>();
}
