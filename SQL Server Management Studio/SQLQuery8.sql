--2 
SELECT [Name], COUNT(*)[TotalMinions]
FROM Villains v
JOIN MinionsVillains mv ON mv.VillainId = v.Id
GROUP BY [Name]
HAVING COUNT(*) > 3
ORDER BY TotalMinions



--3
declare @Id INT = 1

SELECT Name FROM Villains WHERE Id = @Id

SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name