using Helpers;
using Lesson04Task05.Class;

IntHelpers intHelpers = new IntHelpers();
StringHelpers stringHelpers = new StringHelpers();
DoubleHelpers doubleHelpers = new DoubleHelpers();
SexHelpers sexHelpers = new SexHelpers();

Person person = new Person();

Console.WriteLine("Wprowadż dane osoby");
person.FirstName = stringHelpers.GiveMeString("Podaj Imię: ");
person.LastName = stringHelpers.GiveMeString("Podaj Nazwisko: ");
person.PhoneNumber = stringHelpers.GiveMeString("Podaj numer telefonu: ");
person.Email = stringHelpers.GiveMeString("Podaj adres e-mail: ");
person.Growth = doubleHelpers.GiveMeDouble("Podaj wzrost: ");
person.Weight = doubleHelpers.GiveMeDouble("Podaj wagę: ");
person.Age = intHelpers.GiveMeInt("Podaj wiek: ");
person.Sex = sexHelpers.GiveMeSex("Podaj płeć (m lub k): ");
person.PESEL = stringHelpers.GiveMeString("Podaj PESEL: ");

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