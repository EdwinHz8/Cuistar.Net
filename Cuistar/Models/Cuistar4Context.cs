using Microsoft.EntityFrameworkCore;

namespace Cuistar.Models;

public partial class Cuistar4Context : DbContext
{
    public Cuistar4Context()
    {
    }

    public Cuistar4Context(DbContextOptions<Cuistar4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Estatura> Estaturas { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    public virtual DbSet<OrdenVenta> OrdenVentas { get; set; }

    public virtual DbSet<Peso> Pesos { get; set; }

    public virtual DbSet<Pqr> Pqrs { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Roll> Rolls { get; set; }

    public virtual DbSet<Salida> Salidas { get; set; }

    public virtual DbSet<StockInventario> StockInventarios { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<TipoPqr> TipoPqrs { get; set; }

    public virtual DbSet<TipoProducto> TipoProductos { get; set; }

    public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            //  => optionsBuilder.UseSqlServer("server=localhost; database=cuistar4; integrated security=true; TrustServerCertificate=Yes");
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("pk_categoria");

            entity.ToTable("categoria", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdCategoria)
                .HasComment("TRIAL")
                .HasColumnName("id_categoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial721)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL721");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("pk_ciudad");

            entity.ToTable("ciudad", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdCiudad)
                .HasComment("TRIAL")
                .HasColumnName("id_ciudad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial744)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL744");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("pk_estado");

            entity.ToTable("estado", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdEstado)
                .HasComment("TRIAL")
                .HasColumnName("id_estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial744)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL744");
        });

        modelBuilder.Entity<Estatura>(entity =>
        {
            entity.HasKey(e => e.IdEstatura).HasName("pk_estatura");

            entity.ToTable("estatura", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdEstatura)
                .HasComment("TRIAL")
                .HasColumnName("id_estatura");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial747)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL747");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.IdGenero).HasName("pk_genero");

            entity.ToTable("genero", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdGenero)
                .HasComment("TRIAL")
                .HasColumnName("id_genero");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial747)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL747");
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.HasKey(e => e.IdMascota).HasName("pk_mascotas");

            entity.ToTable("mascotas", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdCategoria, "idx_id_categoria").HasFillFactor(99);

            entity.HasIndex(e => e.IdEstatura, "idx_id_estatura").HasFillFactor(99);

            entity.HasIndex(e => e.IdGenero, "idx_id_genero").HasFillFactor(99);

            entity.HasIndex(e => e.IdPeso, "idx_id_peso").HasFillFactor(99);

            entity.HasIndex(e => e.IdUsuario, "idx_id_usuario").HasFillFactor(99);

            entity.Property(e => e.IdMascota)
                .HasComment("TRIAL")
                .HasColumnName("id_mascota");
            entity.Property(e => e.EdadMascota)
                .HasComment("TRIAL")
                .HasColumnName("edad_mascota");
            entity.Property(e => e.IdCategoria)
                .HasComment("TRIAL")
                .HasColumnName("id_categoria");
            entity.Property(e => e.IdEstatura)
                .HasComment("TRIAL")
                .HasColumnName("id_estatura");
            entity.Property(e => e.IdGenero)
                .HasComment("TRIAL")
                .HasColumnName("id_genero");
            entity.Property(e => e.IdPeso)
                .HasComment("TRIAL")
                .HasColumnName("id_peso");
            entity.Property(e => e.IdUsuario)
                .HasComment("TRIAL")
                .HasColumnName("id_usuario");
            entity.Property(e => e.NombreMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("nombre_mascota");
            entity.Property(e => e.Raza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("raza");
            entity.Property(e => e.Trial750)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL750");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("mascotas_ibfk_4");

            entity.HasOne(d => d.IdEstaturaNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdEstatura)
                .HasConstraintName("mascotas_ibfk_5");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdGenero)
                .HasConstraintName("mascotas_ibfk_2");

            entity.HasOne(d => d.IdPesoNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdPeso)
                .HasConstraintName("mascotas_ibfk_3");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("mascotas_ibfk_1");
        });

        modelBuilder.Entity<OrdenVenta>(entity =>
        {
            entity.HasKey(e => e.IdVentas).HasName("pk_orden_ventas");

            entity.ToTable("orden_ventas", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdInventario, "idx_id_inventario").HasFillFactor(99);

            entity.HasIndex(e => e.IdTipoPago, "idx_id_tipo_pago").HasFillFactor(99);

            entity.HasIndex(e => e.IdUsuario, "idx_id_usuario").HasFillFactor(99);

            entity.Property(e => e.IdVentas)
                .HasComment("TRIAL")
                .HasColumnName("id_ventas");
            entity.Property(e => e.CantidasProductos)
                .HasComment("TRIAL")
                .HasColumnName("cantidas_productos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha)
                .HasComment("TRIAL")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdInventario)
                .HasComment("TRIAL")
                .HasColumnName("id_inventario");
            entity.Property(e => e.IdSalida)
                .HasComment("TRIAL")
                .HasColumnName("id_salida");
            entity.Property(e => e.IdTipoPago)
                .HasComment("TRIAL")
                .HasColumnName("id_tipo_pago");
            entity.Property(e => e.IdUsuario)
                .HasComment("TRIAL")
                .HasColumnName("id_usuario");
            entity.Property(e => e.PrecioTotal)
                .HasComment("TRIAL")
                .HasColumnName("precio_total");
            entity.Property(e => e.Trial754)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL754");

            entity.HasOne(d => d.IdInventarioNavigation).WithMany(p => p.OrdenVenta)
                .HasForeignKey(d => d.IdInventario)
                .HasConstraintName("orden_ventas_ibfk_1");

            entity.HasOne(d => d.IdTipoPagoNavigation).WithMany(p => p.OrdenVenta)
                .HasForeignKey(d => d.IdTipoPago)
                .HasConstraintName("orden_ventas_ibfk_2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.OrdenVenta)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("orden_ventas_ibfk_3");
        });

        modelBuilder.Entity<Peso>(entity =>
        {
            entity.HasKey(e => e.IdPeso).HasName("pk_peso");

            entity.ToTable("peso", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdPeso)
                .HasComment("TRIAL")
                .HasColumnName("id_peso");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial754)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL754");
        });

        modelBuilder.Entity<Pqr>(entity =>
        {
            entity.HasKey(e => e.IdPqrs).HasName("pk_pqrs");

            entity.ToTable("pqrs", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdEstado, "idx_id_estado").HasFillFactor(99);

            entity.HasIndex(e => e.IdTipo, "idx_id_tipo").HasFillFactor(99);

            entity.HasIndex(e => e.IdUsuario, "idx_id_usuario").HasFillFactor(99);

            entity.Property(e => e.IdPqrs)
                .HasComment("TRIAL")
                .HasColumnName("id_pqrs");
            entity.Property(e => e.Asunto)
                .HasComment("TRIAL")
                .HasColumnName("asunto");
            entity.Property(e => e.Evidencia)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("evidencia");
            entity.Property(e => e.Fecha)
                .HasComment("TRIAL")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEstado)
                .HasComment("TRIAL")
                .HasColumnName("id_estado");
            entity.Property(e => e.IdTipo)
                .HasComment("TRIAL")
                .HasColumnName("id_tipo");
            entity.Property(e => e.IdUsuario)
                .HasComment("TRIAL")
                .HasColumnName("id_usuario");
            entity.Property(e => e.Respuesta)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("respuesta");
            entity.Property(e => e.Trial757)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL757");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Pqrs)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("pqrs_ibfk_3");

            entity.HasOne(d => d.IdTipoNavigation).WithMany(p => p.Pqrs)
                .HasForeignKey(d => d.IdTipo)
                .HasConstraintName("pqrs_ibfk_2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Pqrs)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("pqrs_ibfk_1");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProductos).HasName("pk_productos");

            entity.ToTable("productos", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdCategoria, "idx_id_categoria").HasFillFactor(99);

            entity.HasIndex(e => e.IdTallas, "idx_id_tallas").HasFillFactor(99);

            entity.HasIndex(e => e.IdTipoprodu, "idx_id_tipoprodu").HasFillFactor(99);

            entity.HasIndex(e => e.IdUnidadmedida, "idx_id_unidadmedida").HasFillFactor(99);

            entity.Property(e => e.IdProductos)
                .HasComment("TRIAL")
                .HasColumnName("id_productos");
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion_producto");
            entity.Property(e => e.IdCategoria)
                .HasComment("TRIAL")
                .HasColumnName("id_categoria");
            entity.Property(e => e.IdTallas)
                .HasComment("TRIAL")
                .HasColumnName("id_tallas");
            entity.Property(e => e.IdTipoprodu)
                .HasComment("TRIAL")
                .HasColumnName("id_tipoprodu");
            entity.Property(e => e.IdUnidadmedida)
                .HasComment("TRIAL")
                .HasColumnName("id_unidadmedida");
            entity.Property(e => e.Imagen)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("imagen");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("nombre_producto");
            entity.Property(e => e.PrecioUnitario)
                .HasComment("TRIAL")
                .HasColumnName("precio_unitario");
            entity.Property(e => e.Trial757)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL757");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("productos_ibfk_4");

            entity.HasOne(d => d.IdTallasNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTallas)
                .HasConstraintName("productos_ibfk_5");

            entity.HasOne(d => d.IdTipoproduNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTipoprodu)
                .HasConstraintName("productos_ibfk_1");

            entity.HasOne(d => d.IdUnidadmedidaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdUnidadmedida)
                .HasConstraintName("productos_ibfk_3");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdNit).HasName("pk_proveedores");

            entity.ToTable("proveedores", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdProducto, "idx_id_producto").HasFillFactor(99);

            entity.Property(e => e.IdNit)
                .ValueGeneratedNever()
                .HasComment("TRIAL")
                .HasColumnName("id_nit");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("apellidos");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("direccion");
            entity.Property(e => e.Fecha)
                .HasComment("TRIAL")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdProducto)
                .HasComment("TRIAL")
                .HasColumnName("id_producto");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("nombres");
            entity.Property(e => e.Teléfono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("teléfono");
            entity.Property(e => e.Trial760)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL760");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("proveedores_ibfk_1");
        });

        modelBuilder.Entity<Roll>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("pk_roll");

            entity.ToTable("roll", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdRol)
                .HasComment("TRIAL")
                .HasColumnName("id_rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial760)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL760");
        });

        modelBuilder.Entity<Salida>(entity =>
        {
            entity.HasKey(e => e.IdSalida).HasName("pk_salidas");

            entity.ToTable("salidas", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdSalida)
                .ValueGeneratedNever()
                .HasComment("TRIAL")
                .HasColumnName("id_salida");
            entity.Property(e => e.Trial763)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL763");
            entity.Property(e => e.ValorSalida)
                .HasComment("TRIAL")
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("valor_salida");
        });

        modelBuilder.Entity<StockInventario>(entity =>
        {
            entity.HasKey(e => e.IdInventario).HasName("pk_stock_inventario");

            entity.ToTable("stock_inventario", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdProducto, "idx_id_producto").HasFillFactor(99);

            entity.HasIndex(e => e.IdSalidas, "idx_id_salidas").HasFillFactor(99);

            entity.Property(e => e.IdInventario)
                .HasComment("TRIAL")
                .HasColumnName("id_inventario");
            entity.Property(e => e.CantidadActual)
                .HasComment("TRIAL")
                .HasColumnName("cantidad_actual");
            entity.Property(e => e.Entradas)
                .HasComment("TRIAL")
                .HasColumnName("entradas");
            entity.Property(e => e.Fecha)
                .HasComment("TRIAL")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdProducto)
                .HasComment("TRIAL")
                .HasColumnName("id_producto");
            entity.Property(e => e.IdSalidas)
                .HasComment("TRIAL")
                .HasColumnName("id_salidas");
            entity.Property(e => e.PrecioTotal)
                .HasComment("TRIAL")
                .HasColumnName("precio_total");
            entity.Property(e => e.Trial767)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL767");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.StockInventarios)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("stock_inventario_ibfk_1");

            entity.HasOne(d => d.IdSalidasNavigation).WithMany(p => p.StockInventarios)
                .HasForeignKey(d => d.IdSalidas)
                .HasConstraintName("stock_inventario_ibfk_2");
        });

        modelBuilder.Entity<Talla>(entity =>
        {
            entity.HasKey(e => e.IdTallas).HasName("pk_tallas");

            entity.ToTable("tallas", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdTallas)
                .HasComment("TRIAL")
                .HasColumnName("id_tallas");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial770)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL770");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("pk_tipo_pago");

            entity.ToTable("tipo_pago", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdPago)
                .HasComment("TRIAL")
                .HasColumnName("id_pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial770)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL770");
        });

        modelBuilder.Entity<TipoPqr>(entity =>
        {
            entity.HasKey(e => e.IdTipo).HasName("pk_tipo_pqrs");

            entity.ToTable("tipo_pqrs", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdTipo)
                .HasComment("TRIAL")
                .HasColumnName("id_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial773)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL773");
        });

        modelBuilder.Entity<TipoProducto>(entity =>
        {
            entity.HasKey(e => e.IdTipoprodu).HasName("pk_tipo_producto");

            entity.ToTable("tipo_producto", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdTipoprodu)
                .HasComment("TRIAL")
                .HasColumnName("id_tipoprodu");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial776)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL776");
        });

        modelBuilder.Entity<UnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.IdUnidadmedida).HasName("pk_unidad_medida");

            entity.ToTable("unidad_medida", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.IdUnidadmedida)
                .HasComment("TRIAL")
                .HasColumnName("id_unidadmedida");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("descripcion");
            entity.Property(e => e.Trial776)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL776");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("pk_usuarios");

            entity.ToTable("usuarios", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.IdCiudad, "idx_id_ciudad").HasFillFactor(99);

            entity.HasIndex(e => e.IdRoll, "idx_id_roll").HasFillFactor(99);

            entity.Property(e => e.IdUsuario)
                .HasComment("TRIAL")
                .HasColumnName("id_usuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("apellidos");
            entity.Property(e => e.Cedula)
                .HasComment("TRIAL")
                .HasColumnName("cedula");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("contrasena");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("correo");
            entity.Property(e => e.IdCiudad)
                .HasComment("TRIAL")
                .HasColumnName("id_ciudad");
            entity.Property(e => e.IdRoll)
                .HasComment("TRIAL")
                .HasColumnName("id_roll");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("telefono");
          

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("usuarios_ibfk_2");

            entity.HasOne(d => d.IdRollNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRoll)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuarios_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
