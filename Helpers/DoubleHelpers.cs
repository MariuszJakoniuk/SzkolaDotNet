namespace Helpers;

public class DoubleHelpers
{
    public double GiveMeDouble(string text)
    {
        double number = 0;
        string numberString;
        bool isTrue;
        bool isError = false;
        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            numberString = Console.ReadLine();
            isTrue = IsDouble(numberString, ref number);
            isError = true;
        }
        while (isTrue == false);

        return number;
    }

    public bool IsDouble(string text, ref double number)
    {
        return double.TryParse(text, out number);
    }
    public bool IsDouble(string text)
    {
        double number = 1;
        return IsDouble(text, ref number);
    }
}