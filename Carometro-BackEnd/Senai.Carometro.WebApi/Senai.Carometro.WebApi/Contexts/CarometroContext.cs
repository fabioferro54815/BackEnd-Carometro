using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.Carometro.WebApi.Domains
{
    public partial class CarometroContext : DbContext
    {
        public CarometroContext()
        {
        }

        public CarometroContext(DbContextOptions<CarometroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alunos> Alunos { get; set; }
        public virtual DbSet<CategoriaOcorrecias> CategoriaOcorrecias { get; set; }
        public virtual DbSet<Cursos> Cursos { get; set; }
        public virtual DbSet<Ocorrecias> Ocorrecias { get; set; }
        public virtual DbSet<Salas> Salas { get; set; }
        public virtual DbSet<Termos> Termos { get; set; }
        public virtual DbSet<TipoCursos> TipoCursos { get; set; }
        public virtual DbSet<Turnos> Turnos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS3T; Initial Catalog=Carometro;User Id=sa;Pwd=sa132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>(entity =>
            {
                entity.HasKey(e => e.IdAluno);

                entity.HasIndex(e => e.NumeroMatricula)
                    .HasName("UQ__Alunos__8B9D7E45D27D400F")
                    .IsUnique();

                entity.Property(e => e.Celular)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFId")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdsalaNavigation)
                    .WithMany(p => p.Alunos)
                    .HasForeignKey(d => d.Idsala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Alunos__Idsala__5CD6CB2B");
            });

            modelBuilder.Entity<CategoriaOcorrecias>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaOcorrecia);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cursos>(entity =>
            {
                entity.HasKey(e => e.IdCurso);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ocorrecias>(entity =>
            {
                entity.HasKey(e => e.IdOcorrecia);

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Falta).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdAlunoNavigation)
                    .WithMany(p => p.Ocorrecias)
                    .HasForeignKey(d => d.IdAluno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocorrecia__IdAlu__6383C8BA");

                entity.HasOne(d => d.IdCategoriaOcorrenciaNavigation)
                    .WithMany(p => p.Ocorrecias)
                    .HasForeignKey(d => d.IdCategoriaOcorrencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocorrecia__IdCat__6477ECF3");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Ocorrecias)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ocorrecia__IdUsu__628FA481");
            });

            modelBuilder.Entity<Salas>(entity =>
            {
                entity.HasKey(e => e.IdSala);

                entity.HasIndex(e => e.Titulo)
                    .HasName("UQ__Salas__7B406B56F8160525")
                    .IsUnique();

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Salas__IdCurso__571DF1D5");

                entity.HasOne(d => d.IdTermoNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.IdTermo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Salas__IdTermo__5812160E");

                entity.HasOne(d => d.IdTipoCursoNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.IdTipoCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Salas__IdTipoCur__5629CD9C");

                entity.HasOne(d => d.IdTurnoNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.IdTurno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Salas__IdTurno__59063A47");
            });

            modelBuilder.Entity<Termos>(entity =>
            {
                entity.HasKey(e => e.IdTermo);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoCursos>(entity =>
            {
                entity.HasKey(e => e.IdTipoCurso);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Turnos>(entity =>
            {
                entity.HasKey(e => e.IdTurno);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.HasIndex(e => e.Nif)
                    .HasName("UQ__Usuarios__C7DEC33030C30C96")
                    .IsUnique();

                entity.Property(e => e.Nif).HasColumnName("NIF");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUsuario).HasDefaultValueSql("((0))");
            });
        }
    }
}
