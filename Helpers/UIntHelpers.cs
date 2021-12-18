namespace Helpers;

public class UIntHelpers
{
    public uint GiveMe(string text)
    {
        uint number = 0;
        string numberString;
        bool isTrue;
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            numberString = Console.ReadLine();
            isTrue = IsUInt(numberString, ref number);
            isError = true;
        }
        while (isTrue == false);

        return number;
    }

    public bool IsUInt(string text, ref uint number)
    {
        return uint.TryParse(text, out number);
    }

    public bool IsUInt(string text)
    {
        uint number = 1;
        return IsUInt(text, ref number);
    }
}