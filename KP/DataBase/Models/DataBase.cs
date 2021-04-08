using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class DataBase : DbContext
    {
        public DataBase()
        {
        }

        public DataBase(DbContextOptions<DataBase> options)
            : base(options)
        {
        }

        public virtual DbSet<BodyCar> BodyCars { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarPickup> CarPickups { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<DamageType> DamageTypes { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<VerDetail> VerDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=C:\\Users\\alber\\Desktop\\KP\\KP\\DataBase\\DataBase_client_contract_auto.mdf;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BodyCar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Vin)
                    .HasName("PK_Car");

                entity.Property(e => e.Vin)
                    .HasMaxLength(17)
                    .HasColumnName("VIN")
                    .IsFixedLength(true);

                entity.Property(e => e.GovNumber)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsFixedLength(true);

                entity.Property(e => e.IdbodyCar).HasColumnName("IDBodyCar");

                entity.Property(e => e.Idcolor).HasColumnName("IDColor");

                entity.Property(e => e.Idmodel).HasColumnName("IDModel");

                entity.Property(e => e.PathImg)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Tcoeff).HasColumnName("TCoeff");

                entity.HasOne(d => d.IdbodyCarNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.IdbodyCar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_BodyCar");

                entity.HasOne(d => d.IdcolorNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.Idcolor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Color");

                entity.HasOne(d => d.IdmodelNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.Idmodel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Model");
            });

            modelBuilder.Entity<CarPickup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FullNameAcceptor)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Holding).HasColumnType("date");

                entity.Property(e => e.Idcontract).HasColumnName("IDContract");

                entity.HasOne(d => d.IdcontractNavigation)
                    .WithMany(p => p.CarPickups)
                    .HasForeignKey(d => d.Idcontract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarPickup_Contract");
            });

            modelBuilder.Entity<Client>(entity =>
            {

                entity.HasKey(e => e.Snpasport)
                    .HasName("PK_Client");

                entity.Property(e => e.Snpasport)
                    .ValueGeneratedNever()
                    .IsRequired()
                    .HasColumnName("SNPasport");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SName");

                entity.Property(e => e.StartTimeDl)
                    .HasColumnType("date")
                    .HasColumnName("StartTimeDL");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualSurrender).HasColumnType("date");

                entity.Property(e => e.End).HasColumnType("date");

                entity.Property(e => e.Idclient).HasColumnName("IDClient");

                entity.Property(e => e.Start).HasColumnType("date");

                entity.Property(e => e.Vinauto)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("VINAuto")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdclientNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.Idclient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Client");

                entity.HasOne(d => d.VinautoNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.Vinauto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Car");
            });

            modelBuilder.Entity<DamageType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("nvarchar");

                entity.Property(e => e.FixPrice).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceFrom1year).HasColumnType("money");

                entity.Property(e => e.PriceIn1moth).HasColumnType("money");

                entity.Property(e => e.PriceUpto1year).HasColumnType("money");

                entity.Property(e => e.PriceUpto6mth).HasColumnType("money");
            });

            modelBuilder.Entity<VerDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdcarPickup).HasColumnName("IDCarPickup");

                entity.Property(e => e.IddamageType).HasColumnName("IDDamageType");

                entity.HasOne(d => d.IdcarPickupNavigation)
                    .WithMany(p => p.VerDetails)
                    .HasForeignKey(d => d.IdcarPickup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VerDetails_CarPickup");

                entity.HasOne(d => d.IddamageTypeNavigation)
                    .WithMany(p => p.VerDetails)
                    .HasForeignKey(d => d.IddamageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VerDetails_DamageType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
