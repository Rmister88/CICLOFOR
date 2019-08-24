using System;

namespace Ciclo_For_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los numeros del X hasta Y para comenzar la numeracion");
            Console.WriteLine("De donde arrancamos el ciclo (X): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos el ciclo (Y): ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto deseas que avance el programa: ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                for (int i = x; i > y; i -= z)

                {
                    Console.WriteLine("i = " + i);
                }
            }

            else
            {
                for (int i = x; i < y; i += z)

                {
                    Console.WriteLine("i = " + i);
                }
            }

        }
    }
}