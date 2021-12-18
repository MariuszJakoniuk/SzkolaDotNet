namespace Helpers;

public class NumberHelpers
{
    public bool PrimeNumber(int number)
    {
        if (number == 1)
            return false;
        if (number == 2)
            return true;
        if (EvenNumbers(number))
            return false;
        for (int i = 2; i < number; i++)
        {
            if ((number % i) == 0)
                return false;
        }
        return true;
    }
    public bool EvenNumbers(int number)
    {
        if (number % 2 == 0)
            return true;
        return false;
    }
    public uint lcm(uint numberOne, uint numberTwo)
    {
        if (numberOne<numberTwo)
            return lcm(numberTwo, numberOne);
        uint helper = numberOne;
        while (helper % numberTwo != 0)
            helper += numberOne;
        return helper;
    }
}