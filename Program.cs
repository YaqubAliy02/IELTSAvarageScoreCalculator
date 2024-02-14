using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

System.Console.WriteLine("IELTS score average FOR academic");

System.Console.Write("Listening score: ");
string listeningScoreInput = Console.ReadLine()!;

System.Console.Write("Reading score: ");
string readingScoreInput = Console.ReadLine()!;

System.Console.Write("Speaking score: ");
string speakingScoreInput = Console.ReadLine()!;

System.Console.Write("Writing score: ");

string writingScoreInput = Console.ReadLine()!;
decimal[] scores={
    Convert.ToDecimal(readingScoreInput),
    Convert.ToDecimal(listeningScoreInput),
    Convert.ToDecimal(writingScoreInput),
    Convert.ToDecimal(speakingScoreInput)
    };
decimal averageScore = scores.Average();
decimal remainder = averageScore-(int)averageScore;
remainder = remainder switch
{
    _ when remainder < 0.25m => 0,
    _ when remainder < 0.75m => 0.5m,
    _ => 1,
};

averageScore=(int)averageScore+remainder;

Console.WriteLine($"Avreage score: {averageScore}");
