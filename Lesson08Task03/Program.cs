using Helpers;

IntHelpers intHelpers = new IntHelpers();

int items = intHelpers.GiveMe("Podaj ile podać pozycji ciąg Fibonacciego: ");

int f1 = 0;
int f2 = 0;
int f3 = 0;

Console.WriteLine();
Console.WriteLine("Ciąg Fibonacciego: ");

for (int i = 0; i < items; i++)
{
    if (i == 0)
    {
        Console.WriteLine($"F{i} - 0");
    }
    else if (i == 1)
    {
        Console.WriteLine($"F{i} - 1");
        f1 = 0;
        f2 = 1;
    }
    else
    {
        f3 = f1 + f2;
        f1 = f2;
        f2 = f3;
        Console.WriteLine($"F{i} - {f3}");
    }
}