using Helpers;

ByteHelpers byteHelpers = new ByteHelpers();

Console.WriteLine("Czy możesz zostać posłem, premierem, senatorem, prezydentem?");
byte age = byteHelpers.GiveMe("Podaj ile masz lat: ");

if (age >= 21)
{
    Console.WriteLine("Możesz zostać posłem.");
    if (age >= 25)
    {
        Console.WriteLine("Możesz zostać premierem.");
        if (age >= 30)
        {
            Console.WriteLine("Możesz zostać senatorem.");
            if (age >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem.");
            }
        }
    }
}
else
{
    Console.WriteLine("Oj, oj. Jeszcze musisz poczekać");
}