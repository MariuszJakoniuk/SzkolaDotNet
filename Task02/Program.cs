using Helpers;

CharHelpers charHelpers = new CharHelpers();

char char01 = charHelpers.GiveMeCharLetter("Podaj pierwszą literę: ");
char char02 = charHelpers.GiveMeCharLetter("Podaj drugą literę: ");
char char03 = charHelpers.GiveMeCharLetter("Podaj trzecią literę: ");

Console.WriteLine($"\n\rLitera trzecia to {char03} \n\rLitera druga {char02} \n\rLitera pierwsza {char01}");
Console.ReadLine();