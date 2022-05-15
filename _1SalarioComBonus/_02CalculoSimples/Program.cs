using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        string[] Linha1 = Console.ReadLine().Split(' ');
        int CodigoPeca1 = int.Parse(Linha1[0]);
        int QuantidadePeca1 = int.Parse(Linha1[1]);
        double ValorPeca1 = double.Parse(Linha1[2], CultureInfo.InvariantCulture);

        string[] Linha2 = Console.ReadLine().Split(' ');
        int CodigoPeca2 = int.Parse(Linha2[0]);
        int QuantidadePeca2 = int.Parse(Linha2[1]);
        double ValorPeca2 = double.Parse(Linha2[2], CultureInfo.InvariantCulture);


        double CalculoTotal = (QuantidadePeca1 * ValorPeca1) + (QuantidadePeca2 * ValorPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", CalculoTotal);
        Console.ReadKey();

    }

}
