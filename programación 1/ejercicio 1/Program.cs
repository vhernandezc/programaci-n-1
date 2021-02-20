using System;

namespace programación_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("ingrese una letra");
            letra = Convert.ToChar(Console.ReadLine());
            if (char.IsUpper(letra))
            {
                Console.WriteLine("Es mayuscula");
            }
            else
            {
                Console.WriteLine("Es minuscula");
            }
            Console.ReadKey();


        }
    }
}
