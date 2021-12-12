using Helpers;
using Task01.Class;

IntHelpers intHelpers = new IntHelpers();
StringHelpers stringHelpers = new StringHelpers();
SexHelpers sexHelpers = new SexHelpers();
LongHelpers longHelpers = new LongHelpers();

Employee employee = new Employee();

Console.WriteLine("Wprowadż pracownika");
employee.FirstName = stringHelpers.GiveMeString("Podaj Imię: ");
employee.LastName = stringHelpers.GiveMeString("Podaj Nazwisko: ");
employee.Age = intHelpers.GiveMeInt("Podaj wiek: ");
employee.Sex = sexHelpers.GiveMeSex("Podaj płeć (m lub k): ");
employee.PESEL = stringHelpers.GiveMeString("Podaj PESEL: ");
employee.Id = longHelpers.GiveMeLong("Podaj numer pracownika: ");

Console.WriteLine("\r\nWpisane dane:");
Console.WriteLine($"Imię: { employee.FirstName}");
Console.WriteLine($"Nazwisko: { employee.LastName}");
Console.WriteLine($"Wiek: { employee.Age}");
Console.WriteLine($"Płeć: { employee.Sex}");
Console.WriteLine($"PESEL: { employee.PESEL}");
Console.WriteLine($"Numer pracownika: { employee.Id}");
Console.ReadLine();