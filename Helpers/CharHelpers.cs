namespace Helpers;

public class CharHelpers
{
    public char GiveMe(string text)
    {
        string stringString;
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            stringString = Console.ReadLine();
            isError = true;
        }
        while (stringString.Length != 1);

        return char.Parse(stringString);
    }

    public char GiveMeCharLetter(string text)
    {
        char charLetter;
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            charLetter = GiveMe(text);
            isError = true;
        }
        while (Char.IsLetter(charLetter) == false );

        return charLetter;
    }
}