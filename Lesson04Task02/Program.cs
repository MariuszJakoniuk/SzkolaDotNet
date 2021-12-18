using Helpers;

CharHelpers charHelpers = new CharHelpers();

char one = charHelpers.GiveMeCharLetter("Podaj pierwszą literę: ");
char two = charHelpers.GiveMeCharLetter("Podaj drugą literę: ");
char three = charHelpers.GiveMeCharLetter("Podaj trzecią literę: ");

Console.WriteLine($"\n\rLitera trzecia to {three} \n\rLitera druga {two} \n\rLitera pierwsza {one}");
Console.ReadLine();