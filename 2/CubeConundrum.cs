using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


try
    {
        CubeConundrum cubeyBoi = new CubeConundrum();
        int lolSkeet = cubeyBoi.GetSumOfPossibleGames(12, 13, 14);
        Console.WriteLine($"sum of possy games: {lolSkeet}");
    }
catch (Exception exceptionallySnowy)
    {
        Console.WriteLine($"we done messed up: {exceptionallySnowy.Message}");
    }

    public class CubeConundrum
{
    private Dictionary<int, List<CubeDraw>> games = new Dictionary<int, List<CubeDraw>>();

    public void AddGame(int gameId, List<CubeDraw> draws)
    {
        games.Add(gameId, draws);
    }

    public bool IsGamePossible(int gameId, int redCubes, int greenCubes, int blueCubes)
    {
        if (!games.ContainsKey(gameId))
        {
            return false;
        }

        List<CubeDraw> draws = games[gameId];

        foreach (var draw in draws)
        {
            if (draw.Red > redCubes || draw.Green > greenCubes || draw.Blue > blueCubes)
            {
                return false;
            }
        }

        return true;
    }

    public int GetSumOfPossibleGames(int redCubes, int greenCubes, int blueCubes)
    {
        int sumOfGameIds = 0;

        foreach (var game in games)
        {
            if (IsGamePossible(game.Key, redCubes, greenCubes, blueCubes))
            {
                sumOfGameIds += game.Key;
            }
        }
        return sumOfGameIds;
    }
    
}

public class CubeDraw
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
}