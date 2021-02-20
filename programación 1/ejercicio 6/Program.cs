using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, modu;
            string d;
            b = 2;
            c = 0;
            Console.Write("Ingrese el numero que usted desee \n");
            d = Console.ReadLine();
            a = int.Parse(d);
            while (b < a && c == 0)
            {
                modu = a % b;
                if (modu == 0)
                {
                    c = 1;
                }
                else
                {
                    b = b + 1;
                }
            }
            if (c == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero es PRIMO \n");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero no es PRIMO \n");
            }
            Console.ReadKey();

        }
    }
}
