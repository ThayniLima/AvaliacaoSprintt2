using System;

class URI
{
    static void Main(string[] args)
    {
        decimal N = Decimal.Parse(Console.ReadLine());

        decimal Valor = N;

        Console.WriteLine("NOTAS: ");

        decimal Cem = N / 10000;
        Console.WriteLine((int)Cem + " nota(s) de R$ 100.00");
        N = N % 10000;
        decimal Cinquenta = N / 5000;
        Console.WriteLine((int)Cinquenta + " nota(s) de R$ 50.00");
        N = N % 5000;
        decimal Vinte = N / 2000;
        Console.WriteLine((int)Vinte + " nota(s) de R$ 20.00");
        N = N % 2000;
        decimal Dez = N / 1000;
        Console.WriteLine((int)Dez + " nota(s) de R$ 10.00");
        N = N % 1000;
        decimal Cinco = N / 500;
        Console.WriteLine((int)Cinco + " nota(s) de R$ 5.00");
        N = N % 500;
        decimal Dois = N / 200;
        Console.WriteLine((int)Dois + " nota(s) de R$ 2.00");



        Console.WriteLine("MOEDAS: ");

        N = N % 200;

        decimal um = N / 100;
        Console.WriteLine((int)um + " moeda(s) de R$ 1.00");
        N = N % 100;
        decimal CinquentaCentavos = N / 50;
        Console.WriteLine((int)CinquentaCentavos + " moeda(s) de R$ 0.50");
        N = N % 50;
        decimal VinteCincoCent = N / 25;
        Console.WriteLine((int)VinteCincoCent + " moeda(s) de R$ 0.25");
        N = N % 25;
        decimal DezCent = N / 10;
        Console.WriteLine((int)DezCent + " moeda(s) de R$ 0.10");
        N = N % 10;
        decimal CincoCent = N / 5;
        Console.WriteLine((int)CincoCent + " moeda(s) de R$ 0.05");
        N = N % 5;
        decimal UmCent = N / 1;
        Console.WriteLine((int)UmCent + " moeda(s) de R$ 0.01");

        Console.ReadKey();

    }
}
