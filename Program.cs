// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Two arrays used to generate team names
        string[] adjectives = { "Loyal", "Diligent", "Classy", "Team-Oriented", "Honest" };
        string[] nouns = { "Employee", "Chilhowie Warrior", "Worker", "Golfer", "Stamp Collector" };

        //Get random name
        Random rnd = new Random();
        int adjIndex = rnd.Next(adjectives.Length);
        int nounIndex = rnd.Next(nouns.Length);
        string teamName = adjectives[adjIndex] + " " + nouns[nounIndex];
        Console.WriteLine(teamName);

    }
}
;
