using Helpers;

StringHelpers stringHelpers = new StringHelpers();

Console.WriteLine("Odwracanie ciągu");

string toReverse = stringHelpers.GiveMe("Podaj ciąg znaków: ");
int lenght = toReverse.Length;
string reverse="";


for (int i = 0; i < lenght; i++)
{
    reverse += toReverse.Substring(lenght - 1 - i, 1);
}
 
Console.WriteLine($"Ciąg odwrócony to: {reverse}");