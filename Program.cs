﻿namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();
        
        Fundament fundament = new Fundament();

        double a = 5;

        fundament.CheckOddOrEven(a);

        string cats = "cats are awesome";
         fundament.GetAInterestingFact(cats);
        Console.WriteLine(cats);

    }
}
