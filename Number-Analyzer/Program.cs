/* Number Analyzer - Decision Maker
 * Mattalynn Darden
 1/24/2024
GC C# Week 1 Project */

using System;

int userInputNumber = 0;
string userInputDecision = "maybe";
string userName = "John Doe";

//Extra credit
Console.WriteLine("Please enter your name:");
userName = Console.ReadLine();

Console.WriteLine($"Hello {userName}, wanna play a game?");
userInputDecision = Console.ReadLine();

while (userInputDecision.ToLower().Trim() == "yes")
{
    //Plauing the game
    Console.WriteLine($"Let's play {userName}!!");

    //Prompt the user for integer
    Console.WriteLine("Please enter a number between 1-100 (inclusive)");
    userInputNumber = int.Parse(Console.ReadLine());

    //Xtra Credit :)
    if ((userInputNumber >= 0) && (userInputNumber <= 100))
    {
        //2a: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
        if ((userInputNumber < 60) && (userInputNumber % 2 > 0))
        {
            Console.WriteLine(userInputNumber);
            Console.WriteLine("Odd and less than 60");
        }

        //2b: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
        else if ((userInputNumber % 2 == 0) && (userInputNumber >= 2) && (userInputNumber <= 24))
        {
            Console.WriteLine(userInputNumber);
            Console.WriteLine("Even and less than 25.");
        }

        //2c: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
        else if ((userInputNumber % 2 == 0) && (userInputNumber >= 26) && (userInputNumber <= 60))
        {
            Console.WriteLine(userInputNumber);
            Console.WriteLine("Even and between 26 and 60 inclusive.");
        }

        //2d: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
        else if ((userInputNumber > 60) && (userInputNumber % 2 == 0))
        {
            Console.WriteLine(userInputNumber);
            Console.WriteLine("Even and greater than 60.");
        }

        //2e: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
        else if ((userInputNumber % 2 > 0) && (userInputNumber > 60))
        {
            Console.WriteLine(userInputNumber);
            Console.WriteLine("Odd and greater than 60.");
        }

        //Looping the game
        Console.WriteLine($"Still wanna play, {userName}?");
        userInputDecision = Console.ReadLine();
    }
    //Input validation for userInputNumber
    else
    {
        Console.WriteLine($"You gave me an invalid number {userName}.");
    }
}
Console.WriteLine($"You're a coward {userName}, GAME OVER!!");