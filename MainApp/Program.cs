Console.WriteLine("Hej!");
Console.WriteLine("Vänligen ange förnamn och efternamn nedan.");

Console.WriteLine("Förnamn: ");
string firstName = Console.ReadLine()!;

Console.WriteLine("Efternamn: ");
string lastName = Console.ReadLine()!;

Console.WriteLine("Välkommen " + firstName + " " + lastName + "!");
Console.ReadKey();