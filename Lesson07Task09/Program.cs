using Helpers;

FloatHelpers floatHelpers = new FloatHelpers();

Console.WriteLine("Zomno czy ciepło.");
float temperatura = floatHelpers.GiveMe("Podaj temberaturę: ");

switch (temperatura)
{
    case >= 40:
        Console.WriteLine("a weź wyprowadzam się na Alaskę");
        break;
    case >= 30:
        Console.WriteLine("zaczyna być słabo, bo gorąco");
        break;
    case >= 20:
        Console.WriteLine("w sam raz");
        break; ;
    case >= 10:
        Console.WriteLine("chłodno");
        break;
    case >= 0:
        Console.WriteLine("zimno");
        break;
    default:
        Console.WriteLine("cholernie piździ");
        break;
}
