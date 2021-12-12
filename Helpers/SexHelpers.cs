namespace Helpers;

public class SexHelpers
{
    public char GiveMeSex(string text)
    {
        string stringSex;
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            stringSex = Console.ReadLine().ToLower();
            isError = true;
        }
        while (stringSex !="m" && stringSex != "k");

        return char.Parse(stringSex);
    }
}

