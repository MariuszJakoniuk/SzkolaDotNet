namespace Helpers;

public class ByteHelpers
{
    public byte GiveMe(string text)
    {
        byte number=0;
        string numberString;
        bool isTrue;
        bool isError = false;

        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            numberString = Console.ReadLine();
            isTrue = IsByte(numberString, ref number);
            isError = true;
        }
        while (isTrue == false);

        return number;
    }

    public bool IsByte(string text, ref byte number)
    {
        return byte.TryParse(text, out number);
    }

    public bool IsByte(string text)
    {
        byte number=1;
        return IsByte(text, ref number);
    }
}