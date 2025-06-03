using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.models
{
    public partial class Game_storeContext : DbContext
    {
        public Game_storeContext()
        {
        }

        public Game_storeContext(DbContextOptions<Game_storeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryTbl> CategoryTbls { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Information> Information { get; set; } = null!;
        public virtual DbSet<Shopping> Shoppings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MC-CLD3CZYSQMXO\\SQLEXPRESS;Initial Catalog=Game_store;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryTbl>(entity =>
            {
                entity.HasKey(e => e.Idcategory)
                    .HasName("PK__category__D2F28D791EE1F473");

                entity.ToTable("category_tbl");

                entity.Property(e => e.Idcategory).HasColumnName("IDcategory");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Idcustomer)
                    .HasName("PK__Customer__27889774275BC33C");

                entity.Property(e => e.Idcustomer).HasColumnName("IDcustomer");

                entity.Property(e => e.CreditCard)
                    .HasMaxLength(16)
                    .HasColumnName("creditCard");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(3)
                    .HasColumnName("cvv");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("expiration_date");

                entity.Property(e => e.NameCustomer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nameCustomer");

                entity.Property(e => e.Pass)
                    .HasMaxLength(10)
                    .HasColumnName("pass");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.Idgame)
                    .HasName("PK__Games__EBD55E3FF4309E9E");

                entity.Property(e => e.Idgame).HasColumnName("IDgame");

                entity.Property(e => e.Game1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("game");

                entity.Property(e => e.Idcategory).HasColumnName("IDcategory");

                entity.Property(e => e.Img)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.HasOne(d => d.IdcategoryNavigation)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.Idcategory)
                    .HasConstraintName("FK__Games__IDcategor__398D8EEE");
            });

            modelBuilder.Entity<Information>(entity =>
            {
                entity.HasKey(e => e.IdNumOfShooping)
                    .HasName("PK__informat__34D07F0AE808FECF");

                entity.ToTable("information");

                entity.Property(e => e.Idbuy).HasColumnName("IDbuy");

                entity.Property(e => e.Idgame).HasColumnName("IDgame");

                entity.HasOne(d => d.IdbuyNavigation)
                    .WithMany(p => p.Information)
                    .HasForeignKey(d => d.Idbuy)
                    .HasConstraintName("FK__informati__IDbuy__4BAC3F29");

                entity.HasOne(d => d.IdgameNavigation)
                    .WithMany(p => p.Information)
                    .HasForeignKey(d => d.Idgame)
                    .HasConstraintName("FK__informati__IDgam__4CA06362");
            });

            modelBuilder.Entity<Shopping>(entity =>
            {
                entity.HasKey(e => e.Idbuy)
                    .HasName("PK__Buy__8B235B4A7BC5E0CB");

                entity.ToTable("Shopping");

                entity.Property(e => e.Idbuy).HasColumnName("IDbuy");

                entity.Property(e => e.DateBuy).HasColumnType("date");

                entity.Property(e => e.Idcustomer).HasColumnName("IDcustomer");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdcustomerNavigation)
                    .WithMany(p => p.Shoppings)
                    .HasForeignKey(d => d.Idcustomer)
                    .HasConstraintName("FK__Buy__IDcustomer__48CFD27E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
