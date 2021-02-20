using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables//
            int año;
            Console.WriteLine("ingrese el año");
            año = int.Parse(Console.ReadLine());
            if (año % 4 != 0)
            {
                Console.WriteLine("el año no es bisiesto");
            }
            else if (año % 100 != 0)
            {
                Console.WriteLine("el año es bisiesto");
            }
            else if (año % 400 != 0)
            {
                Console.WriteLine("el año no es bisiesto");
            }
            else
            {
                Console.WriteLine("el año es bisiesto");
            }
            Console.ReadKey();


        }
    }
}
