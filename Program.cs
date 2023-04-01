namespace Decimal_Decomposition;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        int numero, restante, unidades, dezenas, centenas;

        Console.WriteLine("Digite um numero de 0 a 999: ");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        
        restante = numero;

        unidades = restante % 10;
        restante /= 10;

        dezenas = restante % 10;
        restante /= 10;

        centenas = restante;

        Console.WriteLine($"O número {numero} possui:");
        Console.WriteLine($"{unidades} unidade(s)");
        Console.WriteLine($"{dezenas} dezenas(s)");
        Console.WriteLine($"{centenas} centena(s)");
        


    }
}
