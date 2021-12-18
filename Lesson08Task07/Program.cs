using Helpers;

IntHelpers intHelpers = new IntHelpers();
NumberHelpers numberHelpers = new NumberHelpers();

int number;
int empty;
bool isError = true;

Console.WriteLine("Rysujemy diament dla przy podanej liczbie nieparzystej, dla parzystej diamentopodobne");

do
{
    number = intHelpers.GiveMe("Podaj ilość gwiazdek na przekontnej (3 lub więcej): ");
    if (number >= 3)
        isError = false;
    else
        Console.WriteLine("Błąd podaj jeszcze raz.");
}
while (isError);

empty = numberHelpers.EvenNumbers(number) ? number / 2 - 1 : (number - 1) / 2;


for (int i = 0; i < empty; i++)
{

    for (int j = 0; j < empty - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < number - (empty - i) * 2; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < (numberHelpers.EvenNumbers(number) ? 2 : 1); i++)
{
    for (int j = 0; j < number; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = 0; i < empty; i++)
{

    for (int j = 0; j < i + 1; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < number - (i + 1) * 2; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}