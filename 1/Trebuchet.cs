using System;
using System.IO;
using System.Text.RegularExpressions;


string filePath = "1input.txt";
try {
    string[] lines = Trebuchet.ReadFileLines(filePath);
    int totalSum = 0;
    foreach (string line in lines) {
        totalSum += Trebuchet.ProcessDemLinesFoo(line);
    }
    Console.WriteLine($"here is the answer?!??: {totalSum}");
}
catch (Exception exceptionallyCute) {
    Console.WriteLine($"we done messed up: {exceptionallyCute.Message}");
}

public class Trebuchet {
    public static string[] ReadFileLines(string filePath) {
        return File.ReadAllLines(filePath);
    }

    public static int ProcessDemLinesFoo(string line)
    {
        Regex reggedUp = new Regex(@"\d");
        MatchCollection matches = reggedUp.Matches(line);

        if (matches.Count >= 2)
        {
            int firstDiglett = int.Parse(matches[0].Value);
            int lastDiglett = int.Parse(matches[matches.Count - 1].Value);
            int result = firstDiglett * 10 + lastDiglett;
        
            Console.WriteLine($"Processing line: '{line}', First Digit: {firstDiglett}, Last Digit: {lastDiglett}, Result: {result}");
            return result;
        }

        return 0;
    }
}