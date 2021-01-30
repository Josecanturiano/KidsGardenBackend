using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace kidsGardenApi.Models
{
    public partial class kidsGardenContext : DbContext
    {
        public kidsGardenContext()
        {
        }

        public kidsGardenContext(DbContextOptions<kidsGardenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividad> Actividads { get; set; }
        public virtual DbSet<ActividadPlanificadaPorEstudiante> ActividadPlanificadaPorEstudiantes { get; set; }
        public virtual DbSet<ActividadPlanificadaPorSeccion> ActividadPlanificadaPorSeccions { get; set; }
        public virtual DbSet<Competencium> Competencia { get; set; }
        public virtual DbSet<Distrito> Distritos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<GestorDeContenido> GestorDeContenidos { get; set; }
        public virtual DbSet<Grado> Grados { get; set; }
        public virtual DbSet<Imagene> Imagenes { get; set; }
        public virtual DbSet<ImagenesActividad> ImagenesActividads { get; set; }
        public virtual DbSet<Institucion> Institucions { get; set; }
        public virtual DbSet<MecanicaDeActividad> MecanicaDeActividads { get; set; }
        public virtual DbSet<Objetivo> Objetivos { get; set; }
        public virtual DbSet<ObjetivoActividad> ObjetivoActividads { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<RangoDeSuscripcion> RangoDeSuscripcions { get; set; }
        public virtual DbSet<Regional> Regionals { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Seccion> Seccions { get; set; }
        public virtual DbSet<Suscripcion> Suscripcions { get; set; }
        public virtual DbSet<TipoLicencium> TipoLicencia { get; set; }
        public virtual DbSet<TutorYEstudiante> TutorYEstudiantes { get; set; }
        public virtual DbSet<UsuarioPorInstitucion> UsuarioPorInstitucions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.HasKey(e => e.IdActividad);

                entity.ToTable("Actividad");

                entity.Property(e => e.IdActividad).HasColumnName("ID_Actividad");

                entity.Property(e => e.CompetenciaId).HasColumnName("Competencia_ID");

                entity.Property(e => e.ContenidoJson)
                    .IsUnicode(false)
                    .HasColumnName("Contenido_JSON");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.GradoId).HasColumnName("Grado_ID");

                entity.Property(e => e.MecanicaId).HasColumnName("Mecanica_ID");

                entity.Property(e => e.Titulo).IsUnicode(false);

                entity.HasOne(d => d.Competencia)
                    .WithMany(p => p.Actividads)
                    .HasForeignKey(d => d.CompetenciaId)
                    .HasConstraintName("FK_Actividad_Competencia_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ActividadCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Actividad_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Actividads)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Actividad_Estado");

                entity.HasOne(d => d.Grado)
                    .WithMany(p => p.Actividads)
                    .HasForeignKey(d => d.GradoId)
                    .HasConstraintName("FK_Actividad_Grado_ID");

                entity.HasOne(d => d.Mecanica)
                    .WithMany(p => p.Actividads)
                    .HasForeignKey(d => d.MecanicaId)
                    .HasConstraintName("FK_Actividad_Mecanica_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.ActividadModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Actividad_ModificadoPor");
            });

            modelBuilder.Entity<ActividadPlanificadaPorEstudiante>(entity =>
            {
                entity.HasKey(e => e.IdPlanificacion);

                entity.ToTable("Actividad_Planificada_Por_Estudiante");

                entity.Property(e => e.IdPlanificacion).HasColumnName("ID_Planificacion");

                entity.Property(e => e.ActividadSeccionId).HasColumnName("ActividadSeccion_ID");

                entity.Property(e => e.EstudianteId).HasColumnName("Estudiante_ID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Retroalimentacion).IsUnicode(false);

                entity.HasOne(d => d.ActividadSeccion)
                    .WithMany(p => p.ActividadPlanificadaPorEstudiantes)
                    .HasForeignKey(d => d.ActividadSeccionId)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Estudiante_ActividadSeccion_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ActividadPlanificadaPorEstudianteCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Estudiante_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.ActividadPlanificadaPorEstudiantes)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Estudiante_Estado");

                entity.HasOne(d => d.Estudiante)
                    .WithMany(p => p.ActividadPlanificadaPorEstudianteEstudiantes)
                    .HasForeignKey(d => d.EstudianteId)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Estudiante_Estudiante_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.ActividadPlanificadaPorEstudianteModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Estudiante_ModificadoPor");
            });

            modelBuilder.Entity<ActividadPlanificadaPorSeccion>(entity =>
            {
                entity.HasKey(e => e.IdPlanificacion);

                entity.ToTable("Actividad_Planificada_Por_Seccion");

                entity.Property(e => e.IdPlanificacion).HasColumnName("ID_Planificacion");

                entity.Property(e => e.ActividadId).HasColumnName("Actividad_ID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.SeccionId).HasColumnName("Seccion_ID");

                entity.HasOne(d => d.Actividad)
                    .WithMany(p => p.ActividadPlanificadaPorSeccions)
                    .HasForeignKey(d => d.ActividadId)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Seccion_Actividad_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ActividadPlanificadaPorSeccionCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Seccion_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.ActividadPlanificadaPorSeccions)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Seccion_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.ActividadPlanificadaPorSeccionModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Seccion_ModificadoPor");

                entity.HasOne(d => d.Seccion)
                    .WithMany(p => p.ActividadPlanificadaPorSeccions)
                    .HasForeignKey(d => d.SeccionId)
                    .HasConstraintName("FK_Actividad_Planificada_Por_Seccion_Seccion_ID");
            });

            modelBuilder.Entity<Competencium>(entity =>
            {
                entity.HasKey(e => e.IdCompetencia);

                entity.HasIndex(e => e.Competencia, "UQ_Competencia_Competencia")
                    .IsUnique();

                entity.Property(e => e.IdCompetencia).HasColumnName("ID_Competencia");

                entity.Property(e => e.Competencia)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.CompetenciumCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Competencia_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.CompetenciumModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Competencia_ModificadoPor");
            });

            modelBuilder.Entity<Distrito>(entity =>
            {
                entity.HasKey(e => e.IdDistrito);

                entity.ToTable("Distrito");

                entity.Property(e => e.IdDistrito).HasColumnName("ID_Distrito");

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Director).IsUnicode(false);

                entity.Property(e => e.Distrito1)
                    .IsUnicode(false)
                    .HasColumnName("Distrito");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.DistritoCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Distrito_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.DistritoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Distrito_ModificadoPor");

                entity.HasOne(d => d.RegionalNavigation)
                    .WithMany(p => p.Distritos)
                    .HasForeignKey(d => d.Regional)
                    .HasConstraintName("FK_Distrito_Regional");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado).HasColumnName("ID_Estado");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.EstadoCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Estados_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.EstadoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Estados_ModificadoPor");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("Factura");

                entity.Property(e => e.IdFactura).HasColumnName("ID_Factura");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.SuscripcionId).HasColumnName("Suscripcion_ID");

                entity.Property(e => e.Total).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.FacturaCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Factura_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Factura_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.FacturaModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Factura_ModificadoPor");

                entity.HasOne(d => d.Suscripcion)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.SuscripcionId)
                    .HasConstraintName("FK_Factura_Suscripcion_ID");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.ToTable("Genero");

                entity.Property(e => e.IdGenero).HasColumnName("ID_Genero");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.GeneroCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Genero_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.GeneroModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Genero_ModificadoPor");
            });

            modelBuilder.Entity<GestorDeContenido>(entity =>
            {
                entity.HasKey(e => e.IdGestor);

                entity.ToTable("Gestor_De_Contenido");

                entity.Property(e => e.IdGestor).HasColumnName("ID_Gestor");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.PersonaId).HasColumnName("Persona_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.GestorDeContenidoCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Gestor_De_Contenido_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.GestorDeContenidos)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Gestor_De_Contenido_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.GestorDeContenidoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Gestor_De_Contenido_ModificadoPor");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.GestorDeContenidoPersonas)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("FK_Gestor_De_Contenido_Persona_ID");
            });

            modelBuilder.Entity<Grado>(entity =>
            {
                entity.HasKey(e => e.IdGrado);

                entity.ToTable("Grado");

                entity.Property(e => e.IdGrado).HasColumnName("ID_Grado");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.GradoCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Grado_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.GradoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Grado_ModificadoPor");
            });

            modelBuilder.Entity<Imagene>(entity =>
            {
                entity.HasKey(e => e.IdImagen);

                entity.Property(e => e.IdImagen).HasColumnName("ID_Imagen");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("Image_URL");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ImageneCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Imagenes_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.ImageneModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Imagenes_ModificadoPor");
            });

            modelBuilder.Entity<ImagenesActividad>(entity =>
            {
                entity.HasKey(e => e.IdImagenesActividad);

                entity.ToTable("Imagenes_Actividad");

                entity.Property(e => e.IdImagenesActividad).HasColumnName("ID_Imagenes_Actividad");

                entity.Property(e => e.ActividadId).HasColumnName("Actividad_ID");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ImagenId).HasColumnName("Imagen_ID");

                entity.HasOne(d => d.Actividad)
                    .WithMany(p => p.ImagenesActividads)
                    .HasForeignKey(d => d.ActividadId)
                    .HasConstraintName("FK_Imagenes_Actividad_Actividad_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ImagenesActividadCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Imagenes_Actividad_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.ImagenesActividads)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Imagenes_Actividad_Estado");

                entity.HasOne(d => d.Imagen)
                    .WithMany(p => p.ImagenesActividads)
                    .HasForeignKey(d => d.ImagenId)
                    .HasConstraintName("FK_Imagenes_Actividad_Imagen_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.ImagenesActividadModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Imagenes_Actividad_ModificadoPor");
            });

            modelBuilder.Entity<Institucion>(entity =>
            {
                entity.HasKey(e => e.IdInstitucion);

                entity.ToTable("Institucion");

                entity.Property(e => e.IdInstitucion).HasColumnName("ID_Institucion");

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.DistritoId).HasColumnName("Distrito_ID");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.SuscripcionId).HasColumnName("Suscripcion_ID");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.InstitucionCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Institucion_CreadoPor");

                entity.HasOne(d => d.Distrito)
                    .WithMany(p => p.Institucions)
                    .HasForeignKey(d => d.DistritoId)
                    .HasConstraintName("FK_Institucion_Distrito_ID");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Institucions)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Institucion_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.InstitucionModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Institucion_ModificadoPor");

                entity.HasOne(d => d.Suscripcion)
                    .WithMany(p => p.Institucions)
                    .HasForeignKey(d => d.SuscripcionId)
                    .HasConstraintName("FK_Institucion_Suscripcion_ID");
            });

            modelBuilder.Entity<MecanicaDeActividad>(entity =>
            {
                entity.HasKey(e => e.IdMecanica);

                entity.ToTable("Mecanica_De_Actividad");

                entity.HasIndex(e => e.Mecanica, "UQ_Mecanica_De_Actividad_Mecanica")
                    .IsUnique();

                entity.Property(e => e.IdMecanica).HasColumnName("ID_Mecanica");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Mecanica)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.MecanicaDeActividadCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Mecanica_De_Actividad_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.MecanicaDeActividadModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Mecanica_De_Actividad_ModificadoPor");
            });

            modelBuilder.Entity<Objetivo>(entity =>
            {
                entity.HasKey(e => e.IdObjetivo);

                entity.ToTable("Objetivo");

                entity.Property(e => e.IdObjetivo).HasColumnName("ID_Objetivo");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ObjetivoCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Objetivo_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.ObjetivoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Objetivo_ModificadoPor");
            });

            modelBuilder.Entity<ObjetivoActividad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Objetivo_Actividad");

                entity.Property(e => e.ActividadId).HasColumnName("Actividad_ID");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.IdObjetivoActividad)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_ObjetivoActividad");

                entity.Property(e => e.ObjetivoId).HasColumnName("Objetivo_ID");

                entity.HasOne(d => d.Actividad)
                    .WithMany()
                    .HasForeignKey(d => d.ActividadId)
                    .HasConstraintName("FK_Objetivo_Actividad_Actividad_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Objetivo_Actividad_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Objetivo_Actividad_ModificadoPor");

                entity.HasOne(d => d.Objetivo)
                    .WithMany()
                    .HasForeignKey(d => d.ObjetivoId)
                    .HasConstraintName("FK_Objetivo_Actividad_Objetivo_ID");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.IdPago);

                entity.ToTable("Pago");

                entity.Property(e => e.IdPago).HasColumnName("ID_Pago");

                entity.Property(e => e.FacturaId).HasColumnName("Factura_ID");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.MontoTotal)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Monto_Total");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.PagoCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Pago_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Pago_Estado");

                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.FacturaId)
                    .HasConstraintName("FK_Pago_Factura_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.PagoModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Pago_ModificadoPor");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona).HasColumnName("ID_Persona");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaDeNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_de_nacimiento");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Foto)
                    .IsUnicode(false)
                    .HasColumnName("FOTO");

                entity.Property(e => e.GeneroId).HasColumnName("Genero_ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.InverseCreadoPorNavigation)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Persona_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Persona_Estado");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.GeneroId)
                    .HasConstraintName("FK_Persona_Genero_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.InverseModificadoPorNavigation)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Persona_ModificadoPor");
            });

            modelBuilder.Entity<RangoDeSuscripcion>(entity =>
            {
                entity.HasKey(e => e.IdRango);

                entity.ToTable("Rango_De_Suscripcion");

                entity.Property(e => e.IdRango).HasColumnName("ID_Rango");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DuracionDias).HasColumnName("Duracion_Dias");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Precio).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TipoLicenciaId).HasColumnName("Tipo_Licencia_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.RangoDeSuscripcionCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Rango_De_Suscripcion_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.RangoDeSuscripcions)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Rango_De_Suscripcion_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.RangoDeSuscripcionModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Rango_De_Suscripcion_ModificadoPor");

                entity.HasOne(d => d.TipoLicencia)
                    .WithMany(p => p.RangoDeSuscripcions)
                    .HasForeignKey(d => d.TipoLicenciaId)
                    .HasConstraintName("FK_Rango_De_Suscripcion_Tipo_Licencia_ID");
            });

            modelBuilder.Entity<Regional>(entity =>
            {
                entity.HasKey(e => e.IdRegional);

                entity.ToTable("Regional");

                entity.Property(e => e.IdRegional).HasColumnName("ID_Regional");

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Director)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.RegionalCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Regional_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.RegionalModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Regional_ModificadoPor");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.Property(e => e.IdRol).HasColumnName("ID_Rol");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.RoleCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Roles_CreadoPor");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.RoleModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Roles_ModificadoPor");
            });

            modelBuilder.Entity<Seccion>(entity =>
            {
                entity.HasKey(e => e.IdSeccion);

                entity.ToTable("Seccion");

                entity.Property(e => e.IdSeccion).HasColumnName("ID_Seccion");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.GradoId).HasColumnName("Grado_ID");

                entity.Property(e => e.InstitucionId).HasColumnName("Institucion_ID");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.SeccionCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Seccion_CreadoPor");

                entity.HasOne(d => d.Grado)
                    .WithMany(p => p.Seccions)
                    .HasForeignKey(d => d.GradoId)
                    .HasConstraintName("FK_Seccion_Grado_ID");

                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.Seccions)
                    .HasForeignKey(d => d.InstitucionId)
                    .HasConstraintName("FK_Seccion_Institucion_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.SeccionModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Seccion_ModificadoPor");
            });

            modelBuilder.Entity<Suscripcion>(entity =>
            {
                entity.HasKey(e => e.IdSuscripcion);

                entity.ToTable("Suscripcion");

                entity.Property(e => e.IdSuscripcion).HasColumnName("ID_Suscripcion");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Inicio");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Vencimiento");

                entity.Property(e => e.RangoId).HasColumnName("Rango_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.SuscripcionCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Suscripcion_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Suscripcions)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Suscripcion_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.SuscripcionModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Suscripcion_ModificadoPor");

                entity.HasOne(d => d.Rango)
                    .WithMany(p => p.Suscripcions)
                    .HasForeignKey(d => d.RangoId)
                    .HasConstraintName("FK_Suscripcion_Rango_ID");
            });

            modelBuilder.Entity<TipoLicencium>(entity =>
            {
                entity.HasKey(e => e.IdLicencia);

                entity.ToTable("Tipo_Licencia");

                entity.Property(e => e.IdLicencia).HasColumnName("ID_Licencia");

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.TipoLicenciumCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Tipo_Licencia_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.TipoLicencia)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Tipo_Licencia_Estado");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.TipoLicenciumModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Tipo_Licencia_ModificadoPor");
            });

            modelBuilder.Entity<TutorYEstudiante>(entity =>
            {
                entity.HasKey(e => e.IdTutorEstudiante);

                entity.ToTable("Tutor_Y_Estudiante");

                entity.Property(e => e.IdTutorEstudiante).HasColumnName("ID_TutorEstudiante");

                entity.Property(e => e.EstudianteId).HasColumnName("Estudiante_ID");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.TutorId).HasColumnName("Tutor_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.TutorYEstudianteCreadoPorNavigations)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Tutor_Y_Estudiante_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.TutorYEstudiantes)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Tutor_Y_Estudiante_Estado");

                entity.HasOne(d => d.Estudiante)
                    .WithMany(p => p.TutorYEstudianteEstudiantes)
                    .HasForeignKey(d => d.EstudianteId)
                    .HasConstraintName("FK_Tutor_Y_Estudiante_Estudiante_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.TutorYEstudianteModificadoPorNavigations)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Tutor_Y_Estudiante_ModificadoPor");

                entity.HasOne(d => d.Tutor)
                    .WithMany(p => p.TutorYEstudiantes)
                    .HasForeignKey(d => d.TutorId)
                    .HasConstraintName("FK_Tutor_Y_Estudiante_Tutor_ID");
            });

            modelBuilder.Entity<UsuarioPorInstitucion>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario_Por_Institucion");

                entity.HasIndex(e => e.CodigoUsuario, "UQ_Usuario_Por_Institucion_CodigoUsuario")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.Property(e => e.CodigoUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.InstitucionId).HasColumnName("Institucion_ID");

                entity.Property(e => e.PersonaId).HasColumnName("Persona_ID");

                entity.Property(e => e.RolId).HasColumnName("Rol_ID");

                entity.Property(e => e.SeccionId).HasColumnName("Seccion_ID");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.InverseCreadoPorNavigation)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Usuario_Por_Institucion_CreadoPor");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.UsuarioPorInstitucions)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("FK_Usuario_Por_Institucion_Estado");

                entity.HasOne(d => d.Institucion)
                    .WithMany(p => p.UsuarioPorInstitucions)
                    .HasForeignKey(d => d.InstitucionId)
                    .HasConstraintName("FK_Usuario_Por_Institucion_Institucion_ID");

                entity.HasOne(d => d.ModificadoPorNavigation)
                    .WithMany(p => p.InverseModificadoPorNavigation)
                    .HasForeignKey(d => d.ModificadoPor)
                    .HasConstraintName("FK_Usuario_Por_Institucion_ModificadoPor");

                entity.HasOne(d => d.Persona)
                    .WithMany(p => p.UsuarioPorInstitucions)
                    .HasForeignKey(d => d.PersonaId)
                    .HasConstraintName("FK_Usuario_Por_Institucion_Persona_ID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.UsuarioPorInstitucions)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_Usuario_Por_Institucion_Rol_ID");

                entity.HasOne(d => d.Seccion)
                    .WithMany(p => p.UsuarioPorInstitucions)
                    .HasForeignKey(d => d.SeccionId)
                    .HasConstraintName("FK_Usuario_Por_Institucion_Seccion_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
