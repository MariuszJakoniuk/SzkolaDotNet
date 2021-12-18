using Helpers;

DoubleHelpers doubleHelpers = new DoubleHelpers();

Console.WriteLine("Która liczba najwieksza.");
double[] number = new double[3];
double maxNumber=0;

number[0] = doubleHelpers.GiveMe("Podaj pierwsza liczbę: ");
number[1] = doubleHelpers.GiveMe("Podaj drugą liczbę: ");
number[2] = doubleHelpers.GiveMe("Podaj trzecią: ");

for (int i = 0; i < number.Length; i++)
    if (number[i] > maxNumber)
        maxNumber = number[i];

Console.WriteLine(maxNumber + " jest najwieksza liczbą z podanych");