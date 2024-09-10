// See https://aka.ms/new-console-template for more information
Console.WriteLine("GoodJNDJOIGDbye, World!");
Console.WriteLine("Sadface.jpg");
Console.WriteLine("eep");
string letters = "gevhtriyvg";

Console.WriteLine(GenerateRandomLetters(5));
string GenerateRandomLetters(int length)
{
    return new string(
        Enumerable.Repeat(letters, length)
            .Select(letterString => letterString[new Random().Next(letterString.Length)])
            .ToArray());
}

var x = 5;
Console.WriteLine(@$"Hello there i got {x} houses");
