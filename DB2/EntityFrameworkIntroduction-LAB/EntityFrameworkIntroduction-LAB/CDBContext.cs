using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class CDBContext : DbContext
    {
        public CDBContext()
        {
        }

        public CDBContext(DbContextOptions<CDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Character> Characters { get; set; } = null!;
        public virtual DbSet<Continent> Continents { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DailyIncome> DailyIncomes { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<FirstIndex> FirstIndices { get; set; } = null!;
        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<GameType> GameTypes { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemType> ItemTypes { get; set; } = null!;
        public virtual DbSet<Line> Lines { get; set; } = null!;
        public virtual DbSet<Minion> Minions { get; set; } = null!;
        public virtual DbSet<Mountain> Mountains { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Peak> Peaks { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Rectangle> Rectangles { get; set; } = null!;
        public virtual DbSet<River> Rivers { get; set; } = null!;
        public virtual DbSet<Statistic> Statistics { get; set; } = null!;
        public virtual DbSet<Town> Towns { get; set; } = null!;
        public virtual DbSet<Triangle> Triangles { get; set; } = null!;
        public virtual DbSet<Triangles2> Triangles2s { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersGame> UsersGames { get; set; } = null!;
        public virtual DbSet<VEmployeesHiredAfter200> VEmployeesHiredAfter200s { get; set; } = null!;
        public virtual DbSet<WizzardDeposit> WizzardDeposits { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:softuni.database.windows.net,1433;Initial Catalog=C#DB;Persist Security Info=False;User ID=amatsev;Password=A000216a;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Addresses_Towns");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.HasOne(d => d.Statistic)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.StatisticId)
                    .HasConstraintName("FK_Characters_Statistics");
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.Property(e => e.ContinentCode).IsFixedLength();
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryCode).IsFixedLength();

                entity.Property(e => e.ContinentCode).IsFixedLength();

                entity.Property(e => e.CurrencyCode).IsFixedLength();

                entity.Property(e => e.IsoCode).IsFixedLength();

                entity.HasOne(d => d.ContinentCodeNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.ContinentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Countries_Continents");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.CurrencyCode)
                    .HasConstraintName("FK_Countries_Currencies");

                entity.HasMany(d => d.Rivers)
                    .WithMany(p => p.CountryCodes)
                    .UsingEntity<Dictionary<string, object>>(
                        "CountriesRiver",
                        l => l.HasOne<River>().WithMany().HasForeignKey("RiverId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CountriesRivers_Rivers"),
                        r => r.HasOne<Country>().WithMany().HasForeignKey("CountryCode").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CountriesRivers_Countries"),
                        j =>
                        {
                            j.HasKey("CountryCode", "RiverId");

                            j.ToTable("CountriesRivers");

                            j.IndexerProperty<string>("CountryCode").HasMaxLength(2).IsUnicode(false).IsFixedLength();
                        });
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.CurrencyCode).IsFixedLength();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.PaymentNumber).IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departments_Employees");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Employees_Addresses");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Departments");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Employees_Employees");

                entity.HasMany(d => d.Projects)
                    .WithMany(p => p.Employees)
                    .UsingEntity<Dictionary<string, object>>(
                        "EmployeesProject",
                        l => l.HasOne<Project>().WithMany().HasForeignKey("ProjectId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EmployeesProjects_Projects"),
                        r => r.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_EmployeesProjects_Employees"),
                        j =>
                        {
                            j.HasKey("EmployeeId", "ProjectId");

                            j.ToTable("EmployeesProjects");

                            j.IndexerProperty<int>("EmployeeId").HasColumnName("EmployeeID");

                            j.IndexerProperty<int>("ProjectId").HasColumnName("ProjectID");
                        });
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasOne(d => d.GameType)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.GameTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Games_GameTypes");
            });

            modelBuilder.Entity<GameType>(entity =>
            {
                entity.HasOne(d => d.BonusStats)
                    .WithMany(p => p.GameTypes)
                    .HasForeignKey(d => d.BonusStatsId)
                    .HasConstraintName("FK_GameTypes_Statistics");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.InvoiceId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_ItemTypes");

                entity.HasOne(d => d.Statistic)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.StatisticId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Statistics");

                entity.HasMany(d => d.GameTypes)
                    .WithMany(p => p.Items)
                    .UsingEntity<Dictionary<string, object>>(
                        "GameTypeForbiddenItem",
                        l => l.HasOne<GameType>().WithMany().HasForeignKey("GameTypeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GameTypeForbiddenItems_GameTypes"),
                        r => r.HasOne<Item>().WithMany().HasForeignKey("ItemId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GameTypeForbiddenItems_Items"),
                        j =>
                        {
                            j.HasKey("ItemId", "GameTypeId");

                            j.ToTable("GameTypeForbiddenItems");
                        });

                entity.HasMany(d => d.UserGames)
                    .WithMany(p => p.Items)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserGameItem",
                        l => l.HasOne<UsersGame>().WithMany().HasForeignKey("UserGameId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserGameItems_UsersGames"),
                        r => r.HasOne<Item>().WithMany().HasForeignKey("ItemId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserGameItems_Items"),
                        j =>
                        {
                            j.HasKey("ItemId", "UserGameId");

                            j.ToTable("UserGameItems");
                        });
            });

            modelBuilder.Entity<Minion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Mountain>(entity =>
            {
                entity.HasMany(d => d.CountryCodes)
                    .WithMany(p => p.Mountains)
                    .UsingEntity<Dictionary<string, object>>(
                        "MountainsCountry",
                        l => l.HasOne<Country>().WithMany().HasForeignKey("CountryCode").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MountainsCountries_Countries"),
                        r => r.HasOne<Mountain>().WithMany().HasForeignKey("MountainId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_MountainsCountries_Mountains"),
                        j =>
                        {
                            j.HasKey("MountainId", "CountryCode").HasName("PK_MountainsContinents");

                            j.ToTable("MountainsCountries");

                            j.IndexerProperty<string>("CountryCode").HasMaxLength(2).IsUnicode(false).IsFixedLength();
                        });
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Peak>(entity =>
            {
                entity.HasOne(d => d.Mountain)
                    .WithMany(p => p.Peaks)
                    .HasForeignKey(d => d.MountainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Peaks_Mountains");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Triangles2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UsersGame>(entity =>
            {
                entity.Property(e => e.Cash).HasDefaultValueSql("((1000))");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames_Characters");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames_Games");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames_Users1");
            });

            modelBuilder.Entity<VEmployeesHiredAfter200>(entity =>
            {
                entity.ToView("V_EmployeesHiredAfter200");
            });

            modelBuilder.Entity<WizzardDeposit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
