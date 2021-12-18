using Helpers;

UIntHelpers uIntHelpers = new UIntHelpers();
NumberHelpers numberHelpers = new NumberHelpers();

Console.WriteLine("Poszukajmy najmniejszej wspólnej wielokrotności");
uint numberOne = uIntHelpers.GiveMe("Podaj liczbe pierwszą: ");
uint numberTwo = uIntHelpers.GiveMe("Podaj liczbe drugą: ");

Console.WriteLine($"Najmniejszą wspólna wielokrotnością jest: {numberHelpers.lcm(numberOne, numberTwo)}");