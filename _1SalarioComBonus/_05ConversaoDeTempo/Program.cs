using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int segundos;

        int Horas = N / 3600;
        N = N % 3600;

        int Minutos = N / 60;
        N = N % 60;

        int Segundos = N % 60;

        Console.WriteLine("{0}:{1}:{2}", Horas, Minutos, Segundos);
    }

}
