using System;
using System.Collections.Generic;
using System.Threading;

namespace EWstructuras_filas_y_colas_GRAJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Apilamiento();
            Console.WriteLine();
            Cola();
            Console.ReadLine();

        }

        static int factorial(int N)
        {
            if (N == 0) { 
                return 1;
            }
            return  N * factorial(N - 1);

        
        }

        static void Apilamiento()
        {
            Stack<String> Nombres = new Stack<String>();
            Nombres.Push("LinJoss");
            Nombres.Push("Angel");
            Nombres.Push("Leonardo");

            int total = Nombres.Count;

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(" {0} ", Nombres.Pop());
            }

        }

        static void Cola()
        {
            Queue<String> Fila = new Queue<String>();

            Fila.Enqueue("LinJoss");
            Fila.Enqueue("Angel");
            Fila.Enqueue("Leonardo");

            int total=Fila.Count;

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine("Turno de {0}",Fila.Dequeue());
                Thread.Sleep(2000);

            }




        }


    }
}
