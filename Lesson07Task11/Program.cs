using Helpers;

ByteHelpers byteHelpers = new ByteHelpers();

byte rating = 0;
bool isError = true;

Console.WriteLine("Ocena na opis");

do
{
    rating = byteHelpers.GiveMe("Podaj ocenę (skala 1-6): ");
    if (rating > 0 && rating <= 6)
        isError = false;
    else
        Console.WriteLine("Coś poszło nie tak.");
}
while (isError);

Console.Write("Twoja ocenta to: ");

switch (rating)
{
    case 6:
        Console.WriteLine("Celujący");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    default:
        Console.WriteLine("Niedopuszczający");
        break;
}