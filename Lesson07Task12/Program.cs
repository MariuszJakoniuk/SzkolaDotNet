using Helpers;

ByteHelpers byteHelpers = new ByteHelpers();

byte dayOfWeek = (byte)DateTime.Now.DayOfWeek;

Console.Write("Dziś jest: ");

do
{
    switch (dayOfWeek)
    {
        case 1:
            Console.WriteLine("Poniedziałek");
            break;
        case 2:
            Console.WriteLine("Wtorek");
            break;
        case 3:
            Console.WriteLine("Środa");
            break;
        case 4:
            Console.WriteLine("Czwartek");
            break;
        case 5:
            Console.WriteLine("Piatek");
            break;
        case 6:
            Console.WriteLine("Sobota");
            break;
        case 0 or 7:
            Console.WriteLine("Niedziela");
            break;
    }
    Console.WriteLine();
    dayOfWeek = byteHelpers.GiveMe("Podaj liczbę od 1 do 7 a ja Ci powiem jaki dzień tygodnia nalezy do niej. Jesli chcesz zakączyć program podaj liczbe większą niż 7.\n\rPodaj liczbę:");
}
while (dayOfWeek < 8);