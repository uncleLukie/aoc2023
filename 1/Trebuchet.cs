using System;
using System.IO;
using System.Text.RegularExpressions;


string filePath = "1input.txt";
try {
    string[] lines = Trebuchet.ReadFileLines(filePath);
    foreach (string line in lines) {
        Console.WriteLine(line);
    }
}
catch (Exception exceptionallyCute) {
    Console.WriteLine($"we done messed up: {exceptionallyCute.Message}");
}

public class Trebuchet {
    public static string[] ReadFileLines(string filePath) {
        return File.ReadAllLines(filePath);
    }
}