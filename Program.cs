using System;

namespace URI_1067_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            //se colocar i < x será necessário fazer uma verificação se x é impar.Se colcoar i <= x, o i será verificado inclusive com o valor de x, não
            //precisando fazer uma verificação separada
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}
