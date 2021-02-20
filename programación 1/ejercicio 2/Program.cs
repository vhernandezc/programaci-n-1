using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de varibles//
            double descuento, compra, total;
            Console.WriteLine("ingrese total gastado");
            compra = int.Parse(Console.ReadLine());
            if ((compra) > 300)
            {
                descuento = compra * 0.20;
                total = compra - descuento;
                Console.WriteLine("el descuento es:\n" + descuento);
                Console.WriteLine("y el total es:\n" + total);
            }
            else
            {
                Console.WriteLine("no obtuvo ningun descuento, su total es:\n" + compra);
            }
            Console.ReadKey();

        }
    }
}
