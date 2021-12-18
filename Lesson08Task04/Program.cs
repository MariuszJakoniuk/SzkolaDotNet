using Helpers;

IntHelpers intHelpers = new IntHelpers();

int block;
int blockStep = 1;
int blockRow = 1;
bool isError = true;

do
{
    block = intHelpers.GiveMe("Podaj liczbe bloków piramidy/choinki: ");
    if (block >= 0)
        isError = false;
    else
        Console.WriteLine("Błąd podaj jeszcze raz.");
}
while (isError);

Console.WriteLine();
for (int i = 1; i <= block; i++)
{
    Console.Write($"{i} ");
    blockStep++;
    if (blockStep > blockRow)
    {
        blockRow++;
        blockStep = 1;
        Console.WriteLine();
    }
}
Console.WriteLine();