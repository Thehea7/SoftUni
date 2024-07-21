using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P02_FootballBetting.Data.Models;

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
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Bet> Bets { get; set; } = null!;
        public DbSet<PlayerStatistic> PlayersStatistics { get; set; } = null!;

        public FootballBettingContext(DbContextOptions dco) : base(dco)
        {

        }
        public FootballBettingContext() : base()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConnectionString);
        //}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Team>(entity =>
            //{
            //    entity.HasOne(t => t.PrimaryKitColor)
            //        .WithMany(c => c.PrimaryKitTeams)
            //        .HasForeignKey(t => t.PrimaryKitColorId)
            //        .OnDelete(DeleteBehavior.NoAction);

            //    entity.HasOne(t => t.SecondaryKitColor)
            //        .WithMany(c => c.SecondaryKitTeams)
            //        .HasForeignKey(t => t.SecondaryKitColorId)
            //        .OnDelete(DeleteBehavior.NoAction);
            //});

            //modelBuilder.Entity<Game>(entity =>
            //{
            //    entity.HasOne(g => g.HomeTeam)
            //        .WithMany(t => t.HomeGames)
            //        .HasForeignKey(g => g.HomeTeamId)
            //        .OnDelete(DeleteBehavior.NoAction);

            //    entity.HasOne(g => g.AwayTeam)
            //        .WithMany(t => t.AwayGames)
            //        .HasForeignKey(g => g.AwayTeamId)
            //        .OnDelete(DeleteBehavior.NoAction);
            //});

            //modelBuilder.Entity<Player>(entity =>
            //{
            //    entity.HasOne(p => p.Town)
            //        .WithMany(t => t.Players)
            //        .HasForeignKey(p => p.TownId)
            //        .OnDelete(DeleteBehavior.NoAction);
            //});

            modelBuilder.Entity<PlayerStatistic>()
                .HasKey(ps => new
                {
                    ps.GameId,
                    ps.PlayerId
                });
        }
    }
}
