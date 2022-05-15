using System;

class URI
{

    static void Main(string[] args)
    {

        string[] valor = Console.ReadLine().Split(' ');
        int a = int.Parse(valor[0]);
        int b = int.Parse(valor[1]);
        int c = int.Parse(valor[2]);

        int MaiorAB = (a + b + Math.Abs(a - b)) / 2;

        int MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;


        Console.WriteLine(MaiorABC + " eh o maior");
        Console.ReadKey();
    }


}



