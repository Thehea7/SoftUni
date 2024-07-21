using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P02_FootballBetting.Data;
using P02_FootballBetting.Data.Models;

namespace P02_FootballBetting
{
    public class StartUp
    {
        public static void Main()
        {
            FootballBettingContext context = new();
            //User user = new User();
            //user.Name = "Andrey";
            //user.Username = "Thehea7";
            //user.Password = "alabala";
            //user.Email = "fakeEmail";
            //user.Balance = 250;

            //Bet bet = new Bet();

            //bet.Amount = 100;
            //bet.Prediction = "4:2";
            //bet.User = user;
            //bet.GameId = 1;

            //context.Bets.Add(bet);
            //context.SaveChanges();

            //var bets = context.Bets
            //    .Select(b => new
            //    {
            //        b.BetId,
            //        b.User.Name,
            //        b.User.Username,
            //        b.User.Email,
            //        b.Amount,
            //        b.DateTime,
            //        game = $"{b.Game.HomeTeam.Name} vs {b.Game.AwayTeam.Name}",
            //        b.Prediction,
            //        b.Game.Result

            //    }).ToList();

            //foreach (var b in bets)
            //{
            //    Console.WriteLine(b.BetId);
            //    Console.WriteLine(b.Name);
            //    Console.WriteLine(b.Username);
            //    Console.WriteLine(b.Email);
            //    Console.WriteLine(b.Amount);
            //    Console.WriteLine(b.DateTime);
            //    Console.WriteLine(b.game);
            //    Console.WriteLine(b.Prediction);
            //    Console.WriteLine(b.Result);
            //}

            //Game game = new Game();
            //game.HomeTeamId = 1;
            //game.AwayTeamId = 2;
            //game.DateTime = DateTime.Now;
            //game.HomeTeamGoals = 4;
            //game.AwayTeamGoals = 2;

            //context.Games.Add(game);
            //context.SaveChanges();

            //var games =  context.Games
            //    .Select(g => new
            //    {
            //        HomeTeam = g.HomeTeam.Name,
            //        AwayTeam = g.AwayTeam.Name,
            //        Result = $"{g.HomeTeamGoals} - {g.AwayTeamGoals}",
            //        g.DateTime
            //    }).ToList();

            //foreach (var g in games)
            //{
            //    Console.WriteLine($"{g.HomeTeam} vs {g.AwayTeam}");
            //    Console.WriteLine($"{g.Result}");
            //    Console.WriteLine($"{g.DateTime}");
            //}

            //Country country = new Country("Bulgaria");
            //Town town = new Town("Plovdiv");
            //town.Country = country;
            ////Color black = new Color("Black");
            ////Color yellow = new Color("Yellow");
            //Team team = new Team()
            //{
            //    Name = "Lokomotiv",
            //    PrimaryColor = new Color("Blue"),
            //    SecondaryColor = new Color("White"),
            //    LogoUrl = "lpfc.com",
            //    Initials = "LPFC",
            //    Budget = 700000,
            //    Town = town
            //};

            //context.Teams.Add(team);
            //context.SaveChanges();

            //Player player = new Player()
            //{
            //    Name = "Ivelin Popov",
            //    SquadNumber = 9,
            //    TownId = 1,
            //    Position = new Position()
            //    {
            //        Name = "PlayMaker"
            //    },
            //    IsInjured = false,
            //    TeamId = 1
            //};
            //context.Players.Add(player);
            //context.SaveChanges();

            //var players = context.Players
            //    .Select(p => new
            //    {
            //        p.Name,
            //        p.SquadNumber,
            //        From = $"{p.Town.Country.Name} {p.Town.Name} {p.Team.Name}",
            //        Position = p.Position.Name,
            //        p.IsInjured
            //    })
            //    .ToList();

            //foreach (var t in players)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine(t.Name);
            //    sb.AppendLine(t.SquadNumber.ToString());
            //    sb.AppendLine(t.From);
            //    sb.AppendLine(t.IsInjured.ToString());

            //    Console.WriteLine(sb);
            //}

            //var teams = context.Teams
            //    .Select(t => new
            //    {
            //        t.Name,
            //        TownName = t.Town.Name,
            //        PrimaryColorName = t.PrimaryColor.Name,
            //        SecondaryColorName = t.SecondaryColor.Name,
            //        t.Initials,
            //        t.LogoUrl,
            //        t.Budget,
            //        CountryName = t.Town.Country.Name
            //    })
            //    .ToList();

            //foreach (var t in teams)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine(t.Name);
            //    sb.AppendLine(t.CountryName);
            //    sb.AppendLine(t.TownName);
            //    sb.AppendLine(t.Initials);
            //    sb.AppendLine(t.PrimaryColorName);
            //    sb.AppendLine(t.SecondaryColorName);
            //    sb.AppendLine($"{t.Initials} - Budget:{t.Budget}");
            //    Console.WriteLine(sb);
            //}


        }
    }
}
