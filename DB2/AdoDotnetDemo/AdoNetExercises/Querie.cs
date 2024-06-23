using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExercises
{
    public static class Querie
    {
        public const string GetVillainsWithNumberOfMinions = @"SELECT [Name], COUNT(*)[TotalMinions]
                                                              FROM Villains v
                                                              JOIN MinionsVillains mv ON mv.VillainId = v.Id
                                                              GROUP BY [Name]
                                                              HAVING COUNT(*) > 3
                                                              ORDER BY TotalMinions";


        public const string GetVillainByID = @"SELECT Name FROM Villains WHERE Id = @Id";

        public const string GetOrderedMinionsByVillainID = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                                           m.Name, 
                                                           m.Age
                                                           FROM MinionsVillains AS mv
                                                           JOIN Minions As m ON mv.MinionId = m.Id
                                                           WHERE mv.VillainId = @Id
                                                           ORDER BY m.Name";
    }
}
