namespace Helpers;

public class LongHelpers
{
    public long GiveMeLong(string text)
    {
        long number = 0;
        string numberString;
        bool isTrue;
        bool isError = false;
        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            numberString = Console.ReadLine();
            isTrue = IsLong(numberString, ref number);
            isError = true;
        }
        while (isTrue == false);

        return number;
    }

    public bool IsLong(string text, ref Int64 number)
    {
        return long.TryParse(text, out number);
    }
    public bool IsLong(string text)
    {
        Int64 number = 1;
        return IsLong(text, ref number);
    }
}