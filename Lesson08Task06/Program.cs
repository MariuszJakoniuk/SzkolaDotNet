using Helpers;

IntHelpers intHelpers = new IntHelpers();

int number;
double sum=0;
bool isError = true;

do
{
    number = intHelpers.GiveMe("Suma wg. wzoru dla liczb 0-: ");
    if (number >= 1)
        isError = false;
    else
        Console.WriteLine("Błąd podaj jeszcze raz.");
}
while (isError);


Console.WriteLine();

for (int i = 1; i <= number; i++)
{
    sum = sum + 1.0 / i;
}

Console.WriteLine($"Suma wg wzoru to {sum}");