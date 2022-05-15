using System;

class URI
{

    static void Main(string[] args)
    {

        int Idade = int.Parse(Console.ReadLine());
        int N = Idade;

        int Ano = N / 365;
        N = N % 365;
        Console.WriteLine(Ano + " ano(s)");

        int Mes = N / 30;
        N = N % 30;
        Console.WriteLine(Mes + " mes(es)");

        int Dias = N % 30;
        Console.WriteLine(Dias + " dia(s)");


    }

}
