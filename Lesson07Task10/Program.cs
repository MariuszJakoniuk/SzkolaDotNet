using Helpers;

DoubleHelpers doubleHelpers = new DoubleHelpers();

Console.WriteLine("czy z 3 odcinów można zbudować trójkąt");
double first = doubleHelpers.GiveMe("Podaj pierwszy odcinek: ");
double second = doubleHelpers.GiveMe("Podaj drugi odcinek: ");
double three = doubleHelpers.GiveMe("Podaj trzeci odcinek: ");

if ((three > first && three > second && first + second > three) ||
    (second> first && second > three && first+ three  > second) ||
    (first> second && first > three && second + three > first))
    Console.WriteLine("Można zbudować trójkąt");
else
    Console.WriteLine("Nie można zbudować trójkąt");