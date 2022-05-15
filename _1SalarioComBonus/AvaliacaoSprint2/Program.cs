using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        string NomeVendedor = Console.ReadLine();
        double SalarioFixo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        double TotalDeVendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


        double SalarioTotal = (TotalDeVendas * 0.15) + SalarioFixo;


        Console.WriteLine("TOTAL = R$ {0}", SalarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadKey();
    }
}

