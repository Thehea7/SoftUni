using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P02_FootballBetting.Models;

namespace P02_FootballBetting.Data
{
    
    public class FootballBettingContext : DbContext
    {
        private const string ConnectionString =
            "Server=DESKTOP-IKUABEV\\SQLSOFTUNI;Database=FootballBetting;Trusted_Connection=True;TrustServerCertificate=True";

        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Town> Towns { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;

        public FootballBettingContext(DbContextOptions dco) : base(dco)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
