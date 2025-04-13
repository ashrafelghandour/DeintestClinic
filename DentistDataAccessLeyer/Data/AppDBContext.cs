using System;
using System.Collections.Generic;
using DentistDataAccessLeyer.Eintitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DentistDataAccessLeyer.Data;

public partial class AppDBContext : DbContext
{
    public AppDBContext()
    {
    }

    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<PatientWithAdd> PatientWithAdd { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

       
        optionsBuilder
           .UseSqlServer("server=DESKTOP-I3NIFAB;database = DentistDB;Encrypt=false;Integrated Security = true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>(entity =>
        {
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientNote)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.PatientTc)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("PatientTC");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.StateId)
                .HasDefaultValue(1)
                .HasColumnName("StateID");

            entity.HasOne(d => d.Person).WithMany(p => p.Patients)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonID");
        });

        modelBuilder.Entity<PatientWithAdd>(entity =>
        {
            entity.HasNoKey();
        });
        modelBuilder.Entity<Person>(entity =>
        {
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(15);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__States__C3BA3B5A1DEA6234");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserPasswred)
                .HasMaxLength(80)
                .IsFixedLength();
            entity.Property(e => e.UserType).HasMaxLength(50);

            entity.HasOne(d => d.Person).WithMany()
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Person");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
