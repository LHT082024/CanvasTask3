namespace CS_Tests;

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

        double z = 5;

        fundament.CheckOddOrEven(z);

        string cats = "cats are awesome";
         fundament.GetAInterestingFact(cats);
        Console.WriteLine(cats);

      
         fundament.SumTwoNumbers(2, 4);
        // Console.WriteLine(result);

       double result = fundament.SumTwoNumbersOfGivenType(2, 4);
        Console.WriteLine(result);

    }
}
