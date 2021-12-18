using Helpers;

ByteHelpers byteHelpers = new ByteHelpers();

Console.WriteLine("Czy zakwalifikowany  kandydat do rekrutacji: ");
byte math = byteHelpers.GiveMe("Podaj punkty z matematyki: ");
byte physic = byteHelpers.GiveMe("Podaj punkty z fizyki: ");
byte chemistry = byteHelpers.GiveMe("Podaj punkty z chemi: ");

if (math + physic + chemistry > 180 || math + physic > 150 || math + chemistry > 150)
    Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
else
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");