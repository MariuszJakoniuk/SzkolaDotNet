namespace Helpers;

public class IntHelpers
{
    public int GiveMeInt(string text)
    {
        int number = 0;
        string numberString;
        bool isTrue;
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            numberString = Console.ReadLine();
            isTrue = IsInt(numberString, ref number);
            isError = true;
        }
        while (isTrue == false);

        return number;
    }

    public bool IsInt(string text, ref int number)
    {
        return int.TryParse(text, out number);
    }

    public bool IsInt(string text)
    {
        int number=1;
        return IsInt(text, ref number);
    }
}