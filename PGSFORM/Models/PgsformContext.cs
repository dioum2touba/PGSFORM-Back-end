﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PGSFORM.Models
{
    public partial class PgsformContext : DbContext
    {
        public PgsformContext()
        {
        }

        public PgsformContext(DbContextOptions<PgsformContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Commentaire> Commentaire { get; set; }
        public virtual DbSet<Competence> Competence { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Privilege> Privilege { get; set; }
        public virtual DbSet<Privilegeparrole> Privilegeparrole { get; set; }
        public virtual DbSet<Projet> Projet { get; set; }
        public virtual DbSet<Promo> Promo { get; set; }
        public virtual DbSet<Referenciel> Referenciel { get; set; }
        public virtual DbSet<Ressource> Ressource { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<Utilisateurparreferenciel> Utilisateurparreferenciel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentaire>(entity =>
            {
                entity.ToTable("commentaire");

                entity.HasIndex(e => e.RessourceId)
                    .HasName("RessourceId_1821_idx");

                entity.HasIndex(e => e.UtilisateurId)
                    .HasName("UtilisateurId_1821_idx");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Libelle)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Ressource)
                    .WithMany(p => p.Commentaire)
                    .HasForeignKey(d => d.RessourceId)
                    .HasConstraintName("RessourceId_1821");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Commentaire)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("UtilisateurId_1821");
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.ToTable("competence");

                entity.HasIndex(e => e.UtilisateurId)
                    .HasName("UtilisateurId_1823_idx");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Libelle)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Niveau)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Competence)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("UtilisateurId_1823");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notification");

                entity.HasIndex(e => e.CommentaireId)
                    .HasName("CommentaireId_idx");

                entity.HasIndex(e => e.ProjetId)
                    .HasName("ProjetId_idx");

                entity.HasIndex(e => e.RessourceId)
                    .HasName("RessourceId_idx");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Commentaire)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.CommentaireId)
                    .HasConstraintName("CommentaireId");

                entity.HasOne(d => d.Projet)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.ProjetId)
                    .HasConstraintName("ProjetId");

                entity.HasOne(d => d.Ressource)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.RessourceId)
                    .HasConstraintName("RessourceId");
            });

            modelBuilder.Entity<Privilege>(entity =>
            {
                entity.ToTable("privilege");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Privilegeparrole>(entity =>
            {
                entity.ToTable("privilegeparrole");

                entity.HasIndex(e => e.PrivilegeId)
                    .HasName("PrivilegeId_1829_idx");

                entity.HasIndex(e => e.RoleId)
                    .HasName("RoleId_1656_idx");

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.Privilegeparrole)
                    .HasForeignKey(d => d.PrivilegeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PrivilegeId_1829");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Privilegeparrole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleId_1656");
            });

            modelBuilder.Entity<Projet>(entity =>
            {
                entity.ToTable("projet");

                entity.HasIndex(e => e.UtilisateurId)
                    .HasName("UtilisateurId_1815_idx");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Enonce)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Libelle)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PieceJointe)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Projet)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("UtilisateurId_1815");
            });

            modelBuilder.Entity<Promo>(entity =>
            {
                entity.ToTable("promo");

                entity.HasIndex(e => e.ReferentielId)
                    .HasName("ReferentielId_idx");

                entity.Property(e => e.DateDebut).HasColumnType("date");

                entity.Property(e => e.DateFin).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Libelle)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Lieu)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Referentiel)
                    .WithMany(p => p.Promo)
                    .HasForeignKey(d => d.ReferentielId)
                    .HasConstraintName("ReferentielId");
            });

            modelBuilder.Entity<Referenciel>(entity =>
            {
                entity.ToTable("referenciel");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Ressource>(entity =>
            {
                entity.ToTable("ressource");

                entity.HasIndex(e => e.ProjetId)
                    .HasName("ProjetId_1818_idx");

                entity.HasIndex(e => e.UtilisateurId)
                    .HasName("UtilisateurId_1819_idx");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Libelle)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Url)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Projet)
                    .WithMany(p => p.Ressource)
                    .HasForeignKey(d => d.ProjetId)
                    .HasConstraintName("ProjetId_1818");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Ressource)
                    .HasForeignKey(d => d.UtilisateurId)
                    .HasConstraintName("UtilisateurId_1819");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("utilisateur");

                entity.HasIndex(e => e.RoleId)
                    .HasName("RoleId_1843_idx");

                entity.Property(e => e.DateNaissance).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LieuNaissance)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Utilisateur)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleId_1843");
            });

            modelBuilder.Entity<Utilisateurparreferenciel>(entity =>
            {
                entity.ToTable("utilisateurparreferenciel");

                entity.HasIndex(e => e.ReferencielId)
                    .HasName("ReferencielId_1840_idx");

                entity.HasIndex(e => e.UtilisateurId)
                    .HasName("UtilisateurId_1840_idx");

                entity.Property(e => e.DateCreation).HasColumnType("date");

                entity.HasOne(d => d.Referenciel)
                    .WithMany(p => p.Utilisateurparreferenciel)
                    .HasForeignKey(d => d.ReferencielId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ReferencielId_1840");

                entity.HasOne(d => d.Utilisateur)
                    .WithMany(p => p.Utilisateurparreferenciel)
                    .HasForeignKey(d => d.UtilisateurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UtilisateurId_1840");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}