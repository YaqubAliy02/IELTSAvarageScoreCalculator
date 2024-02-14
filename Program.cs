using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("IELTS score average FOR academic");

        Console.Write("Listening score: ");
        string listeningScoreInput = Console.ReadLine();

        Console.Write("Reading score: ");
        string readingScoreInput = Console.ReadLine();

        Console.Write("Speaking score: ");
        string speakingScoreInput = Console.ReadLine();

        Console.Write("Writing score: ");
        string writingScoreInput = Console.ReadLine();

        decimal[] scores = {
            Convert.ToDecimal(readingScoreInput),
            Convert.ToDecimal(listeningScoreInput),
            Convert.ToDecimal(writingScoreInput),
            Convert.ToDecimal(speakingScoreInput)
        };

        decimal averageScore = scores.Average();
        decimal remainder = averageScore - (int)averageScore;

        remainder = remainder switch
        {
            _ when remainder < 0.25m => 0,
            _ when remainder < 0.75m => 0.5m,
            _ => 1
        };

        averageScore = (int)averageScore + remainder;

        string scoreRange = averageScore switch
        {
            5 => "Modest",
            6 or (decimal)6.5 => "Competent",
            7 or (decimal)7.5 => "Good",
            8 or (decimal)8.5 => "Very Good",
            9 => "Expert",
            _ => "Invalid"
        };

        Console.WriteLine($"Your IELTS score range: {scoreRange}");
    }
}
