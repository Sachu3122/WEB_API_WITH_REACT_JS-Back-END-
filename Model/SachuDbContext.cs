using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalDraft.Model
{
    public partial class SachuDbContext : DbContext
    {
        public SachuDbContext()
        {
        }

        public SachuDbContext(DbContextOptions<SachuDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Main> Mains { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=NUNAVATH;Initial Catalog=react;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Pincode)
                    .HasName("PK__country__546084485F0180A2");

                entity.ToTable("country");

                entity.Property(e => e.Pincode).ValueGeneratedNever();

                entity.Property(e => e.District)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Main>(entity =>
            {
                entity.ToTable("main");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalId)
                    .HasColumnType("date")
                    .HasColumnName("additional_id");

                entity.Property(e => e.AddrsExplaination)
                    .HasMaxLength(500)
                    .HasColumnName("addrs_explaination");

                entity.Property(e => e.City)
                    .HasMaxLength(60)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CrctAdd)
                    .HasMaxLength(100)
                    .HasColumnName("crct_add");

                entity.Property(e => e.Describe)
                    .HasMaxLength(550)
                    .HasColumnName("describe");

                entity.Property(e => e.DoorCard)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("door_card");

                entity.Property(e => e.Equipment)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FirstId)
                    .HasColumnType("date")
                    .HasColumnName("first_id");

                entity.Property(e => e.GeoCode)
                    .HasMaxLength(50)
                    .HasColumnName("geo_code");

                entity.Property(e => e.InspectionComments)
                    .HasMaxLength(550)
                    .HasColumnName("Inspection_comments");

                entity.Property(e => e.InspectionDate)
                    .HasColumnType("date")
                    .HasColumnName("inspection_date");

                entity.Property(e => e.LocationCon)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("location_con");

                entity.Property(e => e.Mapcode).HasColumnName("mapcode");

                entity.Property(e => e.PhoneNum).HasColumnName("phone_num");

                entity.Property(e => e.Postal).HasColumnName("postal");

                entity.Property(e => e.PrimaryPhoneIs)
                    .HasMaxLength(10)
                    .HasColumnName("primary_phone_is");

                entity.Property(e => e.PropertyPhoto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("property_photo");

                entity.Property(e => e.States)
                    .HasMaxLength(60)
                    .HasColumnName("states");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
