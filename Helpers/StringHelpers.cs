namespace Helpers;
public class StringHelpers
{
    public string GiveMeString(string text)
    {
        string stringString = "";
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            stringString = Console.ReadLine();
            isError = true;
        }
        while (stringString.Length < 1);

        return stringString;
    }
}