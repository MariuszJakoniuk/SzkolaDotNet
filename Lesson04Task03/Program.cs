using Helpers;
using Lesson04Task03.Class;

DoubleHelpers doubleHelpers = new DoubleHelpers();
Rectangle rectangle = new Rectangle();

Console.WriteLine("Prostokąt - potrzebne dane");
rectangle.Width = doubleHelpers.GiveMeDouble("Podaj szerokość: ");
rectangle.Height = doubleHelpers.GiveMeDouble("Podaj wysokość: ");

Console.WriteLine($"Przekatna prostokata to: {rectangle.DiagonalRectangle()}");
Console.WriteLine($"Powierzchnia prostokata to: {rectangle.AreaRectangle()}");
