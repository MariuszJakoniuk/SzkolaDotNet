using Helpers;
using Task01.Class;

IntHelpers intHelpers = new IntHelpers();
ByteHelpers byteHelpers = new ByteHelpers();    
StringHelpers stringHelpers = new StringHelpers();
SexHelpers sexHelpers = new SexHelpers();
LongHelpers longHelpers = new LongHelpers();

Employee employee = new Employee();

Console.WriteLine("Wprowadż pracownika");
employee.FirstName = stringHelpers.GiveMe("Podaj Imię: ");
employee.LastName = stringHelpers.GiveMe("Podaj Nazwisko: ");
employee.Age = byteHelpers.GiveMe("Podaj wiek: ");
employee.Sex = sexHelpers.GiveMe("Podaj płeć (m lub k): ");
employee.PESEL = stringHelpers.GiveMe("Podaj PESEL: ");
employee.Id = longHelpers.GiveMe("Podaj numer pracownika: ");

Console.WriteLine("\r\nWpisane dane:");
Console.WriteLine($"Imię: { employee.FirstName}");
Console.WriteLine($"Nazwisko: { employee.LastName}");
Console.WriteLine($"Wiek: { employee.Age}");
Console.WriteLine($"Płeć: { employee.Sex}");
Console.WriteLine($"PESEL: { employee.PESEL}");
Console.WriteLine($"Numer pracownika: { employee.Id}");
Console.ReadLine();