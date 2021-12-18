using Helpers;

IntHelpers intHelpers = new IntHelpers();

int number;
bool isError = true;

do
{
    number = intHelpers.GiveMe("3 potęga dla liczb od 1-: ");
    if (number >= 1)
        isError = false;
    else
        Console.WriteLine("Błąd podaj jeszcze raz.");
}
while (isError);


Console.WriteLine();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
}