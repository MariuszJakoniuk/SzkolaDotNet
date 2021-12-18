namespace Helpers;

public class FloatHelpers
{
    public float GiveMe(string text)
    {
        float number = 0;
        string numberString;
        bool isTrue;
        bool isError = false;
        do
        {
            if (isError) Console.WriteLine("Błąd podaj jeszcze raz.");
            Console.Write(text);
            numberString = Console.ReadLine();
            isTrue = IsFloat(numberString, ref number);
            isError = true;
        }
        while (isTrue == false);

        return number;
    }

    public bool IsFloat(string text, ref float number)
    {
        return float.TryParse(text, out number);
    }
    public bool IsFloat(string text)
    {
        float number = 1;
        return IsFloat(text, ref number);
    }
}