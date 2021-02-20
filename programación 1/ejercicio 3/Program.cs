using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, salario, extras, a;
            Console.WriteLine("igrese las horas trabajadas");
            horas = int.Parse(Console.ReadLine());
            if (horas <= 40)
            {
                salario = horas * 16;
                Console.WriteLine("el salario del obrero es de: \n Q" + salario);
            }
            else if (horas > 40)
            {
                a = 40 * 16;
                salario = (horas - 40) * 20 + a;
                Console.WriteLine("el salario es de:\n" + salario);
            }
            Console.ReadKey();

        }
    }
}
