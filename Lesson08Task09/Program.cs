using Helpers;

UIntHelpers uIntHelpers = new UIntHelpers();

uint number = uIntHelpers.GiveMe("Podaj liczbę dziesiętną:");
string binary;

binary = Convert.ToString(number, 2);

Console.WriteLine($"Liczba dwójkowa to: {binary}");