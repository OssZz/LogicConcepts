

var answere = string.Empty;
var options = new List<string> {"s","n" };
do
{
    var a = ConsoleExtension.GetInt("Ingrese primer nuemro");
    var b = ConsoleExtension.GetInt("Ingrese segundo nuemro");
    var c = ConsoleExtension.GetInt("Ingrese tercer nuemro");

    if (a > b && a > c)
    {
        Console.WriteLine($"El numero mayo es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El numero mayo es: {b}");
    }
    else
    {
        Console.WriteLine($"El numero mayo es: {c}");
    }

    do
    {
        answere = ConsoleExtension.GetValidarOptions("¿Desea continuar [S]i, [N]o", options);
    } while (options!.Any(x => x.Equals(answere,StringComparison.CurrentCultureIgnoreCase)));


} while (answere! .Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game over");
  

