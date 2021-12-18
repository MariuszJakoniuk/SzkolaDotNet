using Helpers;
using Lesson04Task05.Class;

ByteHelpers byteHelpers = new ByteHelpers();
StringHelpers stringHelpers = new StringHelpers();
FloatHelpers floatHelpers = new FloatHelpers();
SexHelpers sexHelpers = new SexHelpers();

Person person = new Person();

Console.WriteLine("Wprowadż dane osoby");
person.FirstName = stringHelpers.GiveMe("Podaj Imię: ");
person.LastName = stringHelpers.GiveMe("Podaj Nazwisko: ");
person.PhoneNumber = stringHelpers.GiveMe("Podaj numer telefonu: ");
person.Email = stringHelpers.GiveMe("Podaj adres e-mail: ");
person.Growth = floatHelpers.GiveMe("Podaj wzrost: ");
person.Weight = floatHelpers.GiveMe("Podaj wagę: ");
person.Age = byteHelpers.GiveMe("Podaj wiek: ");
person.Sex = sexHelpers.GiveMe("Podaj płeć (m lub k): ");
person.PESEL = stringHelpers.GiveMe("Podaj PESEL: ");

Console.WriteLine("\r\nWpisane dane:");
Console.WriteLine($"Imię: { person.FirstName}");
Console.WriteLine($"Nazwisko: { person.LastName}");
Console.WriteLine($"Numer telefonu: { person.PhoneNumber}");
Console.WriteLine($"Adres e-mail: { person.Email}");
Console.WriteLine($"Wzrost: { person.Growth}");
Console.WriteLine($"Waga: { person.Weight}");
Console.WriteLine($"Adres e-mail: { person.Email}");
Console.WriteLine($"Wiek: { person.Age}");
Console.WriteLine($"Płeć: { person.Sex}");
Console.WriteLine($"PESEL: { person.PESEL}");
Console.ReadLine();